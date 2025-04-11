namespace ArraysManagement
{
    partial class FormQR
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
            this.numRowsQR = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numColsQR = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.dgvInputMatrix = new System.Windows.Forms.DataGridView();
            this.btnCalculateQR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMatrixQ = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMatrixR = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrthogonalityCheck = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColsQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(205, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descomposición QR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filas M";
            // 
            // numRowsQR
            // 
            this.numRowsQR.Location = new System.Drawing.Point(95, 90);
            this.numRowsQR.Margin = new System.Windows.Forms.Padding(2);
            this.numRowsQR.Name = "numRowsQR";
            this.numRowsQR.Size = new System.Drawing.Size(90, 20);
            this.numRowsQR.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columnas N";
            // 
            // numColsQR
            // 
            this.numColsQR.Location = new System.Drawing.Point(95, 141);
            this.numColsQR.Margin = new System.Windows.Forms.Padding(2);
            this.numColsQR.Name = "numColsQR";
            this.numColsQR.Size = new System.Drawing.Size(90, 20);
            this.numColsQR.TabIndex = 4;
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateMatrix.Location = new System.Drawing.Point(196, 113);
            this.btnGenerateMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(74, 25);
            this.btnGenerateMatrix.TabIndex = 5;
            this.btnGenerateMatrix.Text = "Generar";
            this.btnGenerateMatrix.UseVisualStyleBackColor = false;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            // 
            // dgvInputMatrix
            // 
            this.dgvInputMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputMatrix.Location = new System.Drawing.Point(12, 234);
            this.dgvInputMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInputMatrix.Name = "dgvInputMatrix";
            this.dgvInputMatrix.RowHeadersWidth = 51;
            this.dgvInputMatrix.RowTemplate.Height = 24;
            this.dgvInputMatrix.Size = new System.Drawing.Size(241, 184);
            this.dgvInputMatrix.TabIndex = 6;
            // 
            // btnCalculateQR
            // 
            this.btnCalculateQR.BackColor = System.Drawing.Color.Blue;
            this.btnCalculateQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateQR.Location = new System.Drawing.Point(196, 202);
            this.btnCalculateQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateQR.Name = "btnCalculateQR";
            this.btnCalculateQR.Size = new System.Drawing.Size(74, 28);
            this.btnCalculateQR.TabIndex = 7;
            this.btnCalculateQR.Text = "Calcular Descomposición";
            this.btnCalculateQR.UseVisualStyleBackColor = false;
            this.btnCalculateQR.Click += new System.EventHandler(this.btnCalculateQR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matriz Q";
            // 
            // dgvMatrixQ
            // 
            this.dgvMatrixQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixQ.Location = new System.Drawing.Point(318, 90);
            this.dgvMatrixQ.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMatrixQ.Name = "dgvMatrixQ";
            this.dgvMatrixQ.RowHeadersWidth = 51;
            this.dgvMatrixQ.RowTemplate.Height = 24;
            this.dgvMatrixQ.Size = new System.Drawing.Size(217, 170);
            this.dgvMatrixQ.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Matriz R";
            // 
            // dgvMatrixR
            // 
            this.dgvMatrixR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixR.Location = new System.Drawing.Point(318, 298);
            this.dgvMatrixR.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMatrixR.Name = "dgvMatrixR";
            this.dgvMatrixR.RowHeadersWidth = 51;
            this.dgvMatrixR.RowTemplate.Height = 24;
            this.dgvMatrixR.Size = new System.Drawing.Size(217, 171);
            this.dgvMatrixR.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Validaicón de Ortogonalidad";
            // 
            // txtOrthogonalityCheck
            // 
            this.txtOrthogonalityCheck.Location = new System.Drawing.Point(27, 468);
            this.txtOrthogonalityCheck.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrthogonalityCheck.Name = "txtOrthogonalityCheck";
            this.txtOrthogonalityCheck.Size = new System.Drawing.Size(243, 20);
            this.txtOrthogonalityCheck.TabIndex = 13;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Yellow;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(418, 499);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(71, 28);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(566, 537);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtOrthogonalityCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMatrixR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMatrixQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculateQR);
            this.Controls.Add(this.dgvInputMatrix);
            this.Controls.Add(this.btnGenerateMatrix);
            this.Controls.Add(this.numColsQR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numRowsQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQR";
            this.Text = "QR";
            ((System.ComponentModel.ISupportInitialize)(this.numRowsQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColsQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRowsQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numColsQR;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.DataGridView dgvInputMatrix;
        private System.Windows.Forms.Button btnCalculateQR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMatrixQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMatrixR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrthogonalityCheck;
        private System.Windows.Forms.Button btnVolver;
    }
}