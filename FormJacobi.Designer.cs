namespace ArraysManagement
{
    partial class FormJacobi
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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSizeJacobi = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateSymmetricMatrix = new System.Windows.Forms.Button();
            this.dgvSymmetricMatrix = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxIterations = new System.Windows.Forms.NumericUpDown();
            this.btnCalculateEigenvalues = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstEigenvalues = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConvergenceInfo = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeJacobi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymmetricMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(117, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(305, 34);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métyodo Jacobi para Autovalores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamaño de Matriz N";
            // 
            // numSizeJacobi
            // 
            this.numSizeJacobi.Location = new System.Drawing.Point(141, 61);
            this.numSizeJacobi.Margin = new System.Windows.Forms.Padding(2);
            this.numSizeJacobi.Name = "numSizeJacobi";
            this.numSizeJacobi.Size = new System.Drawing.Size(90, 20);
            this.numSizeJacobi.TabIndex = 2;
            // 
            // btnGenerateSymmetricMatrix
            // 
            this.btnGenerateSymmetricMatrix.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateSymmetricMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSymmetricMatrix.Location = new System.Drawing.Point(141, 84);
            this.btnGenerateSymmetricMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateSymmetricMatrix.Name = "btnGenerateSymmetricMatrix";
            this.btnGenerateSymmetricMatrix.Size = new System.Drawing.Size(120, 52);
            this.btnGenerateSymmetricMatrix.TabIndex = 3;
            this.btnGenerateSymmetricMatrix.Text = "Generar Matriz Simétrica";
            this.btnGenerateSymmetricMatrix.UseVisualStyleBackColor = false;
            this.btnGenerateSymmetricMatrix.Click += new System.EventHandler(this.btnGenerateSymmetricMatrix_Click);
            // 
            // dgvSymmetricMatrix
            // 
            this.dgvSymmetricMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSymmetricMatrix.Location = new System.Drawing.Point(9, 140);
            this.dgvSymmetricMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSymmetricMatrix.Name = "dgvSymmetricMatrix";
            this.dgvSymmetricMatrix.RowHeadersWidth = 51;
            this.dgvSymmetricMatrix.RowTemplate.Height = 24;
            this.dgvSymmetricMatrix.Size = new System.Drawing.Size(222, 170);
            this.dgvSymmetricMatrix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tolerancia";
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(26, 346);
            this.txtTolerance.Margin = new System.Windows.Forms.Padding(2);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(140, 20);
            this.txtTolerance.TabIndex = 6;
            this.txtTolerance.Text = "1e-10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Máximo Iteraciones";
            // 
            // numMaxIterations
            // 
            this.numMaxIterations.Location = new System.Drawing.Point(452, 63);
            this.numMaxIterations.Margin = new System.Windows.Forms.Padding(2);
            this.numMaxIterations.Name = "numMaxIterations";
            this.numMaxIterations.Size = new System.Drawing.Size(90, 20);
            this.numMaxIterations.TabIndex = 8;
            this.numMaxIterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnCalculateEigenvalues
            // 
            this.btnCalculateEigenvalues.BackColor = System.Drawing.Color.Lime;
            this.btnCalculateEigenvalues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateEigenvalues.Location = new System.Drawing.Point(335, 84);
            this.btnCalculateEigenvalues.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateEigenvalues.Name = "btnCalculateEigenvalues";
            this.btnCalculateEigenvalues.Size = new System.Drawing.Size(107, 44);
            this.btnCalculateEigenvalues.TabIndex = 9;
            this.btnCalculateEigenvalues.Text = "Calcular Autovalores";
            this.btnCalculateEigenvalues.UseVisualStyleBackColor = false;
            this.btnCalculateEigenvalues.Click += new System.EventHandler(this.btnCalculateEigenvalues_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Autovalores";
            // 
            // lstEigenvalues
            // 
            this.lstEigenvalues.FormattingEnabled = true;
            this.lstEigenvalues.Location = new System.Drawing.Point(408, 150);
            this.lstEigenvalues.Margin = new System.Windows.Forms.Padding(2);
            this.lstEigenvalues.Name = "lstEigenvalues";
            this.lstEigenvalues.Size = new System.Drawing.Size(162, 160);
            this.lstEigenvalues.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Información de Convergencia:";
            // 
            // txtConvergenceInfo
            // 
            this.txtConvergenceInfo.Location = new System.Drawing.Point(239, 373);
            this.txtConvergenceInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtConvergenceInfo.Multiline = true;
            this.txtConvergenceInfo.Name = "txtConvergenceInfo";
            this.txtConvergenceInfo.Size = new System.Drawing.Size(192, 36);
            this.txtConvergenceInfo.TabIndex = 13;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Yellow;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(501, 445);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(69, 31);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormJacobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtConvergenceInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstEigenvalues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculateEigenvalues);
            this.Controls.Add(this.numMaxIterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTolerance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSymmetricMatrix);
            this.Controls.Add(this.btnGenerateSymmetricMatrix);
            this.Controls.Add(this.numSizeJacobi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormJacobi";
            this.Text = "FormJacobi";
            ((System.ComponentModel.ISupportInitialize)(this.numSizeJacobi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymmetricMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSizeJacobi;
        private System.Windows.Forms.Button btnGenerateSymmetricMatrix;
        private System.Windows.Forms.DataGridView dgvSymmetricMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaxIterations;
        private System.Windows.Forms.Button btnCalculateEigenvalues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstEigenvalues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConvergenceInfo;
        private System.Windows.Forms.Button btnVolver;
    }
}