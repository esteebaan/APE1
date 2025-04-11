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
    public partial class FormMultiplicacionMatrices: Form
    {
        private TextBox[,] matrizATextBoxes;
        private TextBox[,] matrizBTextBoxes;
        private Label[,] matrizResultadoLabels;
        private int tamanoMatriz = 2; // Tamaño predeterminado

        public FormMultiplicacionMatrices()
        {
            InitializeComponent();
            CrearInterfaz();

            this.FormClosing += Form1_FormClosing;
        }
        private void CrearInterfaz()
        {
            // Limpiar matrices existentes
            if (matrizATextBoxes != null)
            {
                foreach (TextBox tb in matrizATextBoxes)
                    if (tb != null) this.Controls.Remove(tb);
            }

            if (matrizBTextBoxes != null)
            {
                foreach (TextBox tb in matrizBTextBoxes)
                    if (tb != null) this.Controls.Remove(tb);
            }

            if (matrizResultadoLabels != null)
            {
                foreach (Label lbl in matrizResultadoLabels)
                    if (lbl != null) this.Controls.Remove(lbl);
            }

            // Crear etiquetas para matrices
            Label lblMatrizA = new Label();
            lblMatrizA.Text = "Matriz A:";
            lblMatrizA.Location = new System.Drawing.Point(20, 80);
            lblMatrizA.AutoSize = true;
            this.Controls.Add(lblMatrizA);

            Label lblMatrizB = new Label();
            lblMatrizB.Text = "Matriz B:";
            lblMatrizB.Location = new System.Drawing.Point(280, 80);
            lblMatrizB.AutoSize = true;
            this.Controls.Add(lblMatrizB);

            Label lblMatrizResultado = new Label();
            lblMatrizResultado.Text = "Resultado (A * B):";
            lblMatrizResultado.Location = new System.Drawing.Point(540, 60);
            lblMatrizResultado.AutoSize = true;
            this.Controls.Add(lblMatrizResultado);

            // Inicializar matrices de controles
            matrizATextBoxes = new TextBox[tamanoMatriz, tamanoMatriz];
            matrizBTextBoxes = new TextBox[tamanoMatriz, tamanoMatriz];
            matrizResultadoLabels = new Label[tamanoMatriz, tamanoMatriz];

            int tamanoControl = 40;
            int espaciado = 5;

            // Crear controles para Matriz A
            for (int i = 0; i < tamanoMatriz; i++)
            {
                for (int j = 0; j < tamanoMatriz; j++)
                {
                    matrizATextBoxes[i, j] = new TextBox();
                    matrizATextBoxes[i, j].Location = new Point(20 + j * (tamanoControl + espaciado), 100 + i * (tamanoControl + espaciado));
                    matrizATextBoxes[i, j].Size = new Size(tamanoControl, tamanoControl);
                    matrizATextBoxes[i, j].Text = "0";
                    matrizATextBoxes[i, j].TextAlign = HorizontalAlignment.Center;
                    this.Controls.Add(matrizATextBoxes[i, j]);
                }
            }

            // Crear controles para Matriz B
            for (int i = 0; i < tamanoMatriz; i++)
            {
                for (int j = 0; j < tamanoMatriz; j++)
                {
                    matrizBTextBoxes[i, j] = new TextBox();
                    matrizBTextBoxes[i, j].Location = new Point(280 + j * (tamanoControl + espaciado), 100 + i * (tamanoControl + espaciado));
                    matrizBTextBoxes[i, j].Size = new Size(tamanoControl, tamanoControl);
                    matrizBTextBoxes[i, j].Text = "0";
                    matrizBTextBoxes[i, j].TextAlign = HorizontalAlignment.Center;
                    this.Controls.Add(matrizBTextBoxes[i, j]);
                }
            }

            // Crear controles para Matriz Resultado
            for (int i = 0; i < tamanoMatriz; i++)
            {
                for (int j = 0; j < tamanoMatriz; j++)
                {
                    matrizResultadoLabels[i, j] = new Label();
                    matrizResultadoLabels[i, j].Location = new Point(540 + j * (tamanoControl + espaciado), 90 + i * (tamanoControl + espaciado));
                    matrizResultadoLabels[i, j].Size = new Size(tamanoControl, tamanoControl);
                    matrizResultadoLabels[i, j].Text = "0";
                    matrizResultadoLabels[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    matrizResultadoLabels[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrizResultadoLabels[i, j].BackColor = Color.LightGray;
                    this.Controls.Add(matrizResultadoLabels[i, j]);
                }
            }
        }

       

        private double[,] MultiplicarMatricesParalelo(double[,] matrizA, double[,] matrizB)
        {
            int n = matrizA.GetLength(0);
            double[,] resultado = new double[n, n];

            // Usando paralelismo para mejorar rendimiento
            Parallel.For(0, n, i =>
            {
                for (int j = 0; j < n; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += matrizA[i, k] * matrizB[k, j];
                    }
                    resultado[i, j] = sum;
                }
            });

            return resultado;
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener matrices desde los TextBox
                double[,] matrizA = new double[tamanoMatriz, tamanoMatriz];
                double[,] matrizB = new double[tamanoMatriz, tamanoMatriz];

                for (int i = 0; i < tamanoMatriz; i++)
                {
                    for (int j = 0; j < tamanoMatriz; j++)
                    {
                        if (!double.TryParse(matrizATextBoxes[i, j].Text, out matrizA[i, j]))
                        {
                            throw new FormatException("Valor no válido en Matriz A en posición [" + i + "," + j + "]");
                        }

                        if (!double.TryParse(matrizBTextBoxes[i, j].Text, out matrizB[i, j]))
                        {
                            throw new FormatException("Valor no válido en Matriz B en posición [" + i + "," + j + "]");
                        }
                    }
                }

                // Multiplicar matrices con paralelismo
                var watch = System.Diagnostics.Stopwatch.StartNew();
                double[,] resultado = MultiplicarMatricesParalelo(matrizA, matrizB);
                watch.Stop();

           

                // Mostrar resultado
                for (int i = 0; i < tamanoMatriz; i++)
                {
                    for (int j = 0; j < tamanoMatriz; j++)
                    {
                        matrizResultadoLabels[i, j].Text = resultado[i, j].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al multiplicar matrices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Random random = new Random();

                    for (int i = 0; i < tamanoMatriz; i++)
                    {
                        for (int j = 0; j < tamanoMatriz; j++)
                        {
                            matrizATextBoxes[i, j].Text = random.Next(1, 10).ToString();
                            matrizBTextBoxes[i, j].Text = random.Next(1, 10).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar números aleatorios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < tamanoMatriz; i++)
                {
                    for (int j = 0; j < tamanoMatriz; j++)
                    {
                        matrizATextBoxes[i, j].Text = "0";
                        matrizBTextBoxes[i, j].Text = "0";
                        matrizResultadoLabels[i, j].Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar matrices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void numTamano_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                NumericUpDown nud = (NumericUpDown)sender;
                tamanoMatriz = (int)nud.Value;
                CrearInterfaz();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar tamaño: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}