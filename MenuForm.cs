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
    public partial class MenuForm: Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Portada portada = new Portada();
            portada.Show();
            this.Hide();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            FormQR formqr = new FormQR();
            formqr.Show();
            this.Hide();
            
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            FormJacobi jacobi = new FormJacobi();
            jacobi.Show();
            this.Hide();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            FormMultiplicacionMatrices multi = new FormMultiplicacionMatrices();
            multi.Show();
            this.Hide();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            FormEcuaciones formEcuaciones = new FormEcuaciones();
            formEcuaciones.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
