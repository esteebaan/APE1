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
    public partial class FormEcuaciones: Form
    {
        private const int InitialEquations = 2;
        private const int MaxEquations = 10;
        private int currentEquations = InitialEquations;

        private TextBox[,] coefficients;
        private TextBox[] results;
        private Label[] xLabels;
        private Label[] equalsLabels;
        public FormEcuaciones()
        {
            InitializeComponent();
            SetupUI();
            this.FormClosing += Form1_FormClosing;
        }

        private void SetupUI()
        {
        
            // Inicializar matrices para almacenar controles
            coefficients = new TextBox[MaxEquations, MaxEquations];
            results = new TextBox[MaxEquations];
            xLabels = new Label[MaxEquations * MaxEquations];
            equalsLabels = new Label[MaxEquations];

            // Crear ecuaciones iniciales
            for (int i = 0; i < InitialEquations; i++)
            {
                CreateEquationRow(i, InitialEquations, equationsPanel);
            }
        }

        private void CreateEquationRow(int rowIndex, int columnCount, Panel panel)
        {
            int yPos = rowIndex * 40 + 10;
            int xPos = 10;

            for (int j = 0; j < columnCount; j++)
            {
                // Coeficiente
                coefficients[rowIndex, j] = new TextBox
                {
                    Location = new Point(xPos, yPos),
                    Size = new Size(50, 30),
                    Text = (rowIndex == j) ? "1" : "0",
                    Tag = $"{rowIndex},{j}"
                };
                panel.Controls.Add(coefficients[rowIndex, j]);
                xPos += 60;

                // Label x_j
                xLabels[rowIndex * MaxEquations + j] = new Label
                {
                    Text = $"x_{j + 1} {(j < columnCount - 1 ? "+" : "")}",
                    Location = new Point(xPos, yPos + 3),
                    Size = new Size(40, 20),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panel.Controls.Add(xLabels[rowIndex * MaxEquations + j]);
                xPos += 40;
            }

            // Label igual
            equalsLabels[rowIndex] = new Label
            {
                Text = "=",
                Location = new Point(xPos, yPos + 3),
                Size = new Size(20, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(equalsLabels[rowIndex]);
            xPos += 20;

            // Resultado
            results[rowIndex] = new TextBox
            {
                Location = new Point(xPos, yPos),
                Size = new Size(50, 30),
                Text = "0",
                Tag = rowIndex.ToString()
            };
            panel.Controls.Add(results[rowIndex]);
        }

        private void UpdateEquationUI()
        {
            Panel panel = equationsPanel;
            panel.Controls.Clear();

            for (int i = 0; i < currentEquations; i++)
            {
                CreateEquationRow(i, currentEquations, panel);
            }
        }
    
private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentEquations; i++)
            {
                for (int j = 0; j < currentEquations; j++)
                {
                    coefficients[i, j].Text = (i == j) ? "1" : "0";
                }
                results[i].Text = "0";
            }

            TextBox txtResults = (TextBox)this.Controls["txtResults"];
            txtResults.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentEquations < MaxEquations)
            {
                currentEquations++;
                UpdateEquationUI();
            }
            else
            {
                MessageBox.Show($"Número máximo de ecuaciones alcanzado ({MaxEquations})");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentEquations > 2)
            {
                currentEquations--;
                UpdateEquationUI();
            }
            else
            {
                MessageBox.Show("Se requieren al menos 2 ecuaciones");
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear matrices
                double[,] A = new double[currentEquations, currentEquations];
                double[] b = new double[currentEquations];

                // Obtener valores
                for (int i = 0; i < currentEquations; i++)
                {
                    for (int j = 0; j < currentEquations; j++)
                    {
                        if (!double.TryParse(coefficients[i, j].Text, out A[i, j]))
                        {
                            MessageBox.Show($"Error al convertir coeficiente en fila {i + 1}, columna {j + 1}");
                            return;
                        }
                    }

                    if (!double.TryParse(results[i].Text, out b[i]))
                    {
                        MessageBox.Show($"Error al convertir resultado en fila {i + 1}");
                        return;
                    }
                }

                // Crear un solucionador y resolver el sistema
                LinearEquationSolver solver = new LinearEquationSolver();
                LinearEquationSolver.SolutionResult result = solver.Solve(A, b);
               

                // Mostrar resultados
                TextBox txtResults = (TextBox)this.Controls["txtResults"];
              
                txtResults.Text = $"Estado: {result.Message}\r\n";
            
                if (result.State == LinearEquationSolver.SolutionState.OneSolution && result.Solution != null)
                {
                    for (int i = 0; i < result.Solution.Length; i++)
                    {
                        txtResults.Text += $"x_{i + 1} = {result.Solution[i]:F4}\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al resolver: {ex.Message}");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
