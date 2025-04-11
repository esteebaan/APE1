namespace ArraysManagement
{
    partial class FormEcuaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /*private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMatrizB = new System.Windows.Forms.DataGridView();
            this.dgvMatrizA = new System.Windows.Forms.DataGridView();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearMatriz = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Resultado";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(771, 275);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.Size = new System.Drawing.Size(427, 228);
            this.dgvResultado.TabIndex = 18;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(535, 402);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(135, 52);
            this.btnMultiplicar.TabIndex = 17;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Matriz B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Matriz A";
            // 
            // dgvMatrizB
            // 
            this.dgvMatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizB.Location = new System.Drawing.Point(14, 473);
            this.dgvMatrizB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvMatrizB.Name = "dgvMatrizB";
            this.dgvMatrizB.RowHeadersWidth = 51;
            this.dgvMatrizB.Size = new System.Drawing.Size(363, 242);
            this.dgvMatrizB.TabIndex = 14;
            // 
            // dgvMatrizA
            // 
            this.dgvMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizA.Location = new System.Drawing.Point(14, 136);
            this.dgvMatrizA.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvMatrizA.Name = "dgvMatrizA";
            this.dgvMatrizA.RowHeadersWidth = 51;
            this.dgvMatrizA.Size = new System.Drawing.Size(363, 249);
            this.dgvMatrizA.TabIndex = 13;
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(477, 13);
            this.txtDimension.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(175, 22);
            this.txtDimension.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dimensión de las matrices NxN:";
            // 
            // btnCrearMatriz
            // 
            this.btnCrearMatriz.Location = new System.Drawing.Point(685, 8);
            this.btnCrearMatriz.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCrearMatriz.Name = "btnCrearMatriz";
            this.btnCrearMatriz.Size = new System.Drawing.Size(133, 34);
            this.btnCrearMatriz.TabIndex = 10;
            this.btnCrearMatriz.Text = "crear";
            this.btnCrearMatriz.UseVisualStyleBackColor = true;
            this.btnCrearMatriz.Click += new System.EventHandler(this.btnCrearMatriz_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1035, 687);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 41);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormEcuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 771);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMatrizB);
            this.Controls.Add(this.dgvMatrizA);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearMatriz);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEcuaciones";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }*/

        private void InitializeComponent()
        {
            this.equationsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equationsPanel
            // 
            this.equationsPanel.Location = new System.Drawing.Point(12, 46);
            this.equationsPanel.Name = "equationsPanel";
            this.equationsPanel.Size = new System.Drawing.Size(670, 205);
            this.equationsPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Calculadora de Ecuaciones";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(62, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(143, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(224, 266);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Blue;
            this.btnSolve.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSolve.Location = new System.Drawing.Point(305, 266);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(84, 29);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.Text = "Resolver";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 319);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(450, 112);
            this.txtResults.TabIndex = 6;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Yellow;
            this.btnAtras.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(589, 448);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Volver";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormEcuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(689, 492);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.equationsPanel);
            this.Name = "FormEcuaciones";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMatrizB;
        private System.Windows.Forms.DataGridView dgvMatrizA;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearMatriz;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel equationsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnAtras;
    }
}