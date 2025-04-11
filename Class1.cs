using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysManagement
{
    internal class LinearEquationSolver
    {
        private const double EPSILON = 1e-10;
        public enum SolutionState
        {
            OneSolution,
            NoSolution,
            InfiniteSolutions
        }
        public class SolutionResult
        {
            public SolutionState State { get; set; }
            public double[] Solution { get; set; }
            public string Message { get; set; }

            public SolutionResult(SolutionState state, double[] solution = null, string message = null)
            {
                State = state;
                Solution = solution;
                Message = message;
            }
        }
        public SolutionResult Solve(double[,] coefficientMatrix, double[] constantVector)
        {
            if (coefficientMatrix == null || constantVector == null)
                throw new ArgumentNullException("Las matrices de entrada no pueden ser nulas");

            int n = constantVector.Length;
            if (coefficientMatrix.GetLength(0) != n || coefficientMatrix.GetLength(1) != n)
                throw new ArgumentException("Dimensiones incompatibles: La matriz de coeficientes debe ser cuadrada y del mismo tamaño que el vector de constantes");

            // Crear matriz aumentada [A|b]
            double[,] augmentedMatrix = CreateAugmentedMatrix(coefficientMatrix, constantVector);

            // Aplicar eliminación de Gauss para llevar la matriz a forma escalonada
            ApplyGaussianElimination(augmentedMatrix, n);

            // Analizar el sistema escalonado
            return AnalyzeEchelonForm(augmentedMatrix, n);
        }
        private double[,] CreateAugmentedMatrix(double[,] coefficientMatrix, double[] constantVector)
        {
            int n = constantVector.Length;
            double[,] augmentedMatrix = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i, j] = coefficientMatrix[i, j];
                }
                augmentedMatrix[i, n] = constantVector[i];
            }

            return augmentedMatrix;
        }
        private void ApplyGaussianElimination(double[,] matrix, int n)
        {
            for (int k = 0; k < n; k++)
            {
                // Pivoteo parcial (seleccionar la fila con el mayor valor absoluto en la columna k)
                int maxRow = FindPivotRow(matrix, k, n);

                // Intercambiar filas si es necesario
                if (maxRow != k)
                    SwapRows(matrix, k, maxRow, n + 1);

                // Si el pivote es prácticamente cero, la columna ya está procesada
                if (Math.Abs(matrix[k, k]) < EPSILON)
                    continue;

                // Eliminación hacia adelante
                for (int i = k + 1; i < n; i++)
                {
                    double factor = matrix[i, k] / matrix[k, k];

                    for (int j = k; j <= n; j++)
                    {
                        matrix[i, j] -= factor * matrix[k, j];

                        // Tratar valores muy pequeños como cero para evitar errores de redondeo
                        if (Math.Abs(matrix[i, j]) < EPSILON)
                            matrix[i, j] = 0;
                    }
                }
            }
        }
        private int FindPivotRow(double[,] matrix, int k, int n)
        {
            int maxRow = k;
            double maxVal = Math.Abs(matrix[k, k]);

            for (int i = k + 1; i < n; i++)
            {
                if (Math.Abs(matrix[i, k]) > maxVal)
                {
                    maxVal = Math.Abs(matrix[i, k]);
                    maxRow = i;
                }
            }

            return maxRow;
        }
        private void SwapRows(double[,] matrix, int row1, int row2, int cols)
        {
            for (int j = 0; j < cols; j++)
            {
                double temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
            }
        }
        private SolutionResult AnalyzeEchelonForm(double[,] matrix, int n)
        {
            // Verificar filas con todos ceros en la parte de coeficientes pero con valor no cero en término independiente
            // Esto indicaría un sistema inconsistente (sin solución)
            for (int i = 0; i < n; i++)
            {
                bool allZeros = true;
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(matrix[i, j]) >= EPSILON)
                    {
                        allZeros = false;
                        break;
                    }
                }

                if (allZeros && Math.Abs(matrix[i, n]) >= EPSILON)
                {
                    return new SolutionResult(
                        SolutionState.NoSolution,
                        null,
                        "El sistema no tiene solución (sistema inconsistente)"
                    );
                }
            }

            // Contar variables libres (columnas sin pivote)
            int rank = CalculateRank(matrix, n);

            if (rank < n)
            {
                return new SolutionResult(
                    SolutionState.InfiniteSolutions,
                    null,
                    $"El sistema tiene infinitas soluciones con {n - rank} variables libres"
                );
            }

            // El sistema tiene solución única, aplicar sustitución hacia atrás
            return new SolutionResult(
                SolutionState.OneSolution,
                BackSubstitution(matrix, n),
                "El sistema tiene una única solución"
            );
        }
        private int CalculateRank(double[,] matrix, int n)
        {
            int rank = 0;
            for (int i = 0; i < n; i++)
            {
                bool nonZeroRow = false;
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(matrix[i, j]) >= EPSILON)
                    {
                        nonZeroRow = true;
                        break;
                    }
                }

                if (nonZeroRow)
                    rank++;
            }

            return rank;
        }
        private double[] BackSubstitution(double[,] matrix, int n)
        {
            double[] solution = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += matrix[i, j] * solution[j];
                }

                // Verificar si el coeficiente diagonal es cero (caso raro debido al pivoteo)
                if (Math.Abs(matrix[i, i]) < EPSILON)
                    solution[i] = 0;
                else
                    solution[i] = (matrix[i, n] - sum) / matrix[i, i];

                // Redondear valores muy cercanos a cero
                if (Math.Abs(solution[i]) < EPSILON)
                    solution[i] = 0;
            }

            return solution;
        }
        public string MatrixToString(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                sb.Append("[ ");
                for (int j = 0; j < cols; j++)
                {
                    sb.Append($"{matrix[i, j]:F4}");
                    if (j < cols - 1)
                        sb.Append("  ");
                }
                sb.AppendLine(" ]");
            }

            return sb.ToString();
        }
    }
}

