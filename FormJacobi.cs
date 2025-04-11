using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysManagement
{
    public partial class FormJacobi : Form
    {
        private double[,] symmetricMatrix;
        private double[] eigenvalues;
        private double[,] eigenvectors;

        public FormJacobi()
        {
            InitializeComponent();

            // Configuración inicial
            numSizeJacobi.Minimum = 2;
            numSizeJacobi.Maximum = 10;
            numSizeJacobi.Value = 3;

            numMaxIterations.Minimum = 10;
            numMaxIterations.Maximum = 1000;
            numMaxIterations.Value = 100;

            txtTolerance.Text = "1e-10";
            txtConvergenceInfo.Multiline = true;
            txtConvergenceInfo.Height = 100;
            txtConvergenceInfo.ReadOnly = true;

            this.FormClosing += Form1_FormClosing;
        }

        private void btnGenerateSymmetricMatrix_Click(object sender, EventArgs e)
        {
            int size = (int)numSizeJacobi.Value;

            // Crear matriz simétrica inicializada en 0
            symmetricMatrix = new double[size, size];

            // Configurar DataGridView
            dgvSymmetricMatrix.AllowUserToAddRows = false; // <- Añade esta línea
            dgvSymmetricMatrix.RowCount = size;
            dgvSymmetricMatrix.ColumnCount = size;

            // Nombrar columnas y llenar con valores predeterminados (0)
            for (int j = 0; j < size; j++)
            {
                dgvSymmetricMatrix.Columns[j].Name = $"Col {j + 1}";
                dgvSymmetricMatrix.Columns[j].Width = 60;

                for (int i = 0; i < size; i++)
                {
                    // Inicializar todas las celdas con 0
                    symmetricMatrix[i, j] = 0;
                    dgvSymmetricMatrix.Rows[i].Cells[j].Value = 0;
                }
            }

            // Manejar valores nulos o vacíos al leer la matriz
            dgvSymmetricMatrix.CellEndEdit += (s, args) =>
            {
                int row = dgvSymmetricMatrix.CurrentCell.RowIndex;
                int col = dgvSymmetricMatrix.CurrentCell.ColumnIndex;

                var cellValue = dgvSymmetricMatrix.Rows[row].Cells[col].Value;

                // Si la celda está vacía o nula, asumir el valor 0
                if (cellValue == null || cellValue.ToString() == "")
                {
                    symmetricMatrix[row, col] = 0;
                    dgvSymmetricMatrix.Rows[row].Cells[col].Value = 0;
                }
                else if (double.TryParse(cellValue.ToString(), out double value))
                {
                    symmetricMatrix[row, col] = value;

                    // Mantener la simetría de la matriz
                    if (row != col)
                    {
                        symmetricMatrix[col, row] = value;
                        dgvSymmetricMatrix.Rows[col].Cells[row].Value = value;
                    }
                }
                else
                {
                    MessageBox.Show($"Valor inválido en la posición [{row + 1},{col + 1}]. Se asignará 0.");
                    symmetricMatrix[row, col] = 0;
                    dgvSymmetricMatrix.Rows[row].Cells[col].Value = 0;

                    // Mantener la simetría de la matriz
                    if (row != col)
                    {
                        symmetricMatrix[col, row] = 0;
                        dgvSymmetricMatrix.Rows[col].Cells[row].Value = 0;
                    }
                }
            };
        }

        private void btnCalculateEigenvalues_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer la matriz del DataGridView
                int rows = dgvSymmetricMatrix.RowCount;
                int cols = dgvSymmetricMatrix.ColumnCount;

                // Validar que el DataGridView tenga datos válidos
                //if (rows != cols)
                //{
                //    MessageBox.Show("El DataGridView debe ser una matriz cuadrada");
                //    return;
                //}

                int size = rows; // Tamaño de la matriz cuadrada
                symmetricMatrix = new double[size, size];

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (dgvSymmetricMatrix.Rows[i].Cells[j].Value == null ||
                            !double.TryParse(dgvSymmetricMatrix.Rows[i].Cells[j].Value.ToString(), out double value))
                        {
                            MessageBox.Show($"Valor inválido en la posición [{i + 1},{j + 1}]");
                            return;
                        }
                        symmetricMatrix[i, j] = value;
                    }
                }

                // Verificar simetría
                if (!IsSymmetric(symmetricMatrix))
                {
                    MessageBox.Show("La matriz debe ser simétrica para aplicar el método de Jacobi");
                    return;
                }

                // Obtener parámetros
                double tolerance;
                if (!double.TryParse(txtTolerance.Text, out tolerance) || tolerance <= 0)
                {
                    MessageBox.Show("La tolerancia debe ser un número positivo válido");
                    return;
                }

                int maxIterations = (int)numMaxIterations.Value;
                if (maxIterations <= 0)
                {
                    MessageBox.Show("El número máximo de iteraciones debe ser mayor que 0");
                    return;
                }

                // Calcular autovalores usando el método de Jacobi
                var result = JacobiMethod(symmetricMatrix, tolerance, maxIterations);
                eigenvalues = result.eigenvalues;
                eigenvectors = result.eigenvectors;
                int iterations = result.iterations;
                double finalError = result.error;

                // Mostrar autovalores en el ListBox
                lstEigenvalues.Items.Clear();
                for (int i = 0; i < eigenvalues.Length; i++)
                {
                    lstEigenvalues.Items.Add($"λ{i + 1} = {eigenvalues[i]:F6}");
                }

                // Mostrar información de convergencia
                txtConvergenceInfo.Text = $"Iteraciones realizadas: {iterations}\r\n" +
                                          $"Error final: {finalError:E6}\r\n" +
                                          $"Convergencia: {(iterations < maxIterations ? "Convergió" : "No convergió")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetalles:\n{ex.StackTrace}");
            }
        }

        private bool IsSymmetric(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++) // Solo verificar la parte triangular inferior
                {
                    if (Math.Abs(matrix[i, j] - matrix[j, i]) > 1e-10)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private (double[] eigenvalues, double[,] eigenvectors, int iterations, double error) JacobiMethod(double[,] A, double tolerance, int maxIterations)
        {
            int n = A.GetLength(0);

            // Crear copia de la matriz para no modificar la original
            double[,] S = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    S[i, j] = A[i, j];
                }
            }

            // Inicializar matriz de vectores propios como identidad
            double[,] V = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                V[i, i] = 1.0;
            }

            int iterations = 0;
            double error = double.MaxValue;

            while (iterations < maxIterations && error > tolerance)
            {
                // Encontrar el elemento máximo fuera de la diagonal
                int p = 0, q = 1;
                double maxOffDiagonal = Math.Abs(S[0, 1]);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j && Math.Abs(S[i, j]) > maxOffDiagonal)
                        {
                            maxOffDiagonal = Math.Abs(S[i, j]);
                            p = i;
                            q = j;
                        }
                    }
                }

                // Calcular error como la norma de Frobenius de los elementos fuera de la diagonal
                error = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            error += S[i, j] * S[i, j];
                        }
                    }
                }
                error = Math.Sqrt(error);

                // Si el error es suficientemente pequeño, terminar
                if (error <= tolerance)
                {
                    break;
                }

                // Calcular la rotación de Jacobi
                double theta;
                if (Math.Abs(S[p, p] - S[q, q]) < 1e-10)
                {
                    theta = Math.PI / 4; // 45 grados si los elementos diagonales son iguales
                }
                else
                {
                    theta = 0.5 * Math.Atan2(2 * S[p, q], S[p, p] - S[q, q]);
                }

                double c = Math.Cos(theta);
                double s = Math.Sin(theta);

                // Aplicar la rotación a S
                double Spp = S[p, p];
                double Sqq = S[q, q];
                double Spq = S[p, q];

                S[p, p] = c * c * Spp + s * s * Sqq - 2 * c * s * Spq;
                S[q, q] = s * s * Spp + c * c * Sqq + 2 * c * s * Spq;
                S[p, q] = S[q, p] = (c * c - s * s) * Spq + c * s * (Spp - Sqq);

                for (int j = 0; j < n; j++)
                {
                    if (j != p && j != q)
                    {
                        double Spj = S[p, j];
                        double Sqj = S[q, j];
                        S[p, j] = S[j, p] = c * Spj - s * Sqj;
                        S[q, j] = S[j, q] = s * Spj + c * Sqj;
                    }
                }

                // Actualizar la matriz de vectores propios
                for (int i = 0; i < n; i++)
                {
                    double Vip = V[i, p];
                    double Viq = V[i, q];
                    V[i, p] = c * Vip - s * Viq;
                    V[i, q] = s * Vip + c * Viq;
                }

                iterations++;
            }

            // Extraer autovalores (elementos diagonales de S)
            double[] eigenvalues = new double[n];
            for (int i = 0; i < n; i++)
            {
                eigenvalues[i] = S[i, i];
            }

            // Ordenar autovalores y vectores propios de mayor a menor
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (eigenvalues[i] < eigenvalues[j])
                    {
                        // Intercambiar autovalores
                        double temp = eigenvalues[i];
                        eigenvalues[i] = eigenvalues[j];
                        eigenvalues[j] = temp;

                        // Intercambiar columnas correspondientes en la matriz de vectores propios
                        for (int k = 0; k < n; k++)
                        {
                            temp = V[k, i];
                            V[k, i] = V[k, j];
                            V[k, j] = temp;
                        }
                    }
                }
            }

            return (eigenvalues, V, iterations, error);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}