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
    public partial class FormQR: Form
    {
        private double[,] matrixInput;
        private double[,] matrixQ;
        private double[,] matrixR;

        public FormQR()
        {
            InitializeComponent();
            numRowsQR.Minimum = 2;
            numRowsQR.Maximum = 10;
            numRowsQR.Value = 3;

            numColsQR.Minimum = 2;
            numColsQR.Maximum = 10;
            numColsQR.Value = 3;

            // Inicializar las matrices en ceros
            matrixInput = new double[10, 10];
            matrixQ = new double[10, 10];
            matrixR = new double[10, 10];

            this.FormClosing += Form1_FormClosing;
        }

        private void CalculateQRDecomposition(double[,] A)
        {
            int m = A.GetLength(0);  // Filas
            int n = A.GetLength(1);  // Columnas

            // Implementación del método de Gram-Schmidt para QR
            matrixQ = new double[m, n];
            matrixR = new double[n, n];

            // Crear arreglos temporales para los vectores columna
            double[][] q = new double[n][];
            double[][] a = new double[n][];

            for (int j = 0; j < n; j++)
            {
                q[j] = new double[m];
                a[j] = new double[m];

                // Obtener la columna j de A
                for (int i = 0; i < m; i++)
                {
                    a[j][i] = A[i, j];
                }
            }

            try
            {
                // Proceso de Gram-Schmidt
                for (int j = 0; j < n; j++)
                {
                    // Comenzar con el vector a_j
                    for (int i = 0; i < m; i++)
                    {
                        q[j][i] = a[j][i];
                    }

                    // Restar las proyecciones de los vectores anteriores
                    for (int k = 0; k < j; k++)
                    {
                        // Calcular el producto escalar <a_j, q_k>
                        double dotProduct = 0;
                        for (int i = 0; i < m; i++)
                        {
                            dotProduct += a[j][i] * q[k][i];
                        }

                        matrixR[k, j] = dotProduct;

                        // Restar la proyección
                        for (int i = 0; i < m; i++)
                        {
                            q[j][i] -= dotProduct * q[k][i];
                        }
                    }

                    // Calcular la norma de q_j
                    double norm = 0;
                    for (int i = 0; i < m; i++)
                    {
                        norm += q[j][i] * q[j][i];
                    }
                    norm = Math.Sqrt(norm);

                    // Verificar si la columna es linealmente dependiente
                    if (norm < 1e-10)
                    {
                        throw new Exception("Matriz con columnas linealmente dependientes");
                    }

                    // Normalizar q_j
                    matrixR[j, j] = norm;
                    for (int i = 0; i < m; i++)
                    {
                        q[j][i] /= norm;
                    }
                }

                // Transferir los valores q a la matriz Q
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        matrixQ[i, j] = q[j][i];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la descomposición QR: " + ex.Message);
            }
        }

        private void DisplayMatrix(DataGridView dgv, double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dgv.RowCount = rows;
            dgv.ColumnCount = cols;

            for (int j = 0; j < cols; j++)
            {
                dgv.Columns[j].Width = 60;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dgv.Rows[i].Cells[j].Value = Math.Round(matrix[i, j], 4);
                }
            }
        }

        private void CheckOrthogonality()
        {
            int cols = matrixQ.GetLength(1);
            bool isOrthogonal = true;
            string message = "";

            // Verificar ortogonalidad: Q^T * Q debe ser aproximadamente la matriz identidad
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double dotProduct = 0;
                    for (int k = 0; k < matrixQ.GetLength(0); k++)
                    {
                        dotProduct += matrixQ[k, i] * matrixQ[k, j];
                    }

                    // Comprobar si es aproximadamente 1 (en la diagonal) o 0 (fuera de la diagonal)
                    double expected = (i == j) ? 1 : 0;
                    if (Math.Abs(dotProduct - expected) > 1e-10)
                    {
                        isOrthogonal = false;
                        message += $"Columnas {i + 1} y {j + 1}: Producto = {dotProduct:F6} (Debería ser {expected})\n";
                    }
                }
            }

            if (isOrthogonal)
            {
                txtOrthogonalityCheck.Text = "Las columnas de Q son ortogonales.";
                txtOrthogonalityCheck.BackColor = Color.LightGreen;
            }
            else
            {
                txtOrthogonalityCheck.Text = "Las columnas de Q NO son ortogonales:\n" + message;
                txtOrthogonalityCheck.BackColor = Color.LightPink;
            }
        }

        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            int rows = (int)numRowsQR.Value;
            int cols = (int)numColsQR.Value;

            // Crear la matriz de entrada inicializada en 0
            matrixInput = new double[rows, cols];

            // Configurar DataGridView
            dgvInputMatrix.RowCount = rows;
            dgvInputMatrix.ColumnCount = cols;

            // Nombrar columnas y llenar con valores predeterminados (0)
            for (int j = 0; j < cols; j++)
            {
                dgvInputMatrix.Columns[j].Name = $"Col {j + 1}";
                dgvInputMatrix.Columns[j].Width = 60;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dgvInputMatrix.Rows[i].Cells[j].Value = 0; // Valor predeterminado
                }
            }
        }
       
        private void btnCalculateQR_Click(object sender, EventArgs e)
        {
            // Leer la matriz actual del DataGridView
            int rows = dgvInputMatrix.RowCount;
            int cols = dgvInputMatrix.ColumnCount;

            try
            {
                // Leer valores del DataGridView
                matrixInput = new double[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        var cellValue = dgvInputMatrix.Rows[i].Cells[j].Value;

                        // Si la celda está vacía o nula, asumir el valor 0
                        if (cellValue == null || cellValue.ToString() == "")
                        {
                            matrixInput[i, j] = 0;
                        }
                        else if (double.TryParse(cellValue.ToString(), out double value))
                        {
                            matrixInput[i, j] = value;
                        }
                        else
                        {
                            MessageBox.Show($"Valor inválido en la posición [{i + 1},{j + 1}]");
                            return;
                        }
                    }
                }

                // Calcular descomposición QR
                CalculateQRDecomposition(matrixInput);

                // Mostrar resultados
                DisplayMatrix(dgvMatrixQ, matrixQ);
                DisplayMatrix(dgvMatrixR, matrixR);

                // Verificar ortogonalidad
                CheckOrthogonality();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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