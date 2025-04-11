namespace ArraysManagement
{
    partial class FormMultiplicacionMatrices
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
            this.numTamano = new System.Windows.Forms.NumericUpDown();
            this.lblTamano = new System.Windows.Forms.Label();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTamano)).BeginInit();
            this.SuspendLayout();
            // 
            // numTamano
            // 
            this.numTamano.Location = new System.Drawing.Point(26, 55);
            this.numTamano.Margin = new System.Windows.Forms.Padding(2);
            this.numTamano.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTamano.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTamano.Name = "numTamano";
            this.numTamano.Size = new System.Drawing.Size(90, 20);
            this.numTamano.TabIndex = 6;
            this.numTamano.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTamano.ValueChanged += new System.EventHandler(this.numTamano_ValueChanged_1);
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamano.Location = new System.Drawing.Point(11, 37);
            this.lblTamano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(123, 15);
            this.lblTamano.TabIndex = 7;
            this.lblTamano.Text = "Tamaño de matrices:";
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.AutoSize = true;
            this.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(123, 54);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(124, 25);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "Multiplicar Matrices";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.BackColor = System.Drawing.Color.Blue;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandom.Location = new System.Drawing.Point(251, 54);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(132, 25);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Llenar con Aleatorios";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(387, 54);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 25);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar Matrices";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Yellow;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Location = new System.Drawing.Point(538, 350);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 33);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Calculadora de Matrices";
            // 
            // FormMultiplicacionMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(688, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.numTamano);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnLimpiar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMultiplicacionMatrices";
            this.Text = "Multiplicacion de Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.numTamano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTamano;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}