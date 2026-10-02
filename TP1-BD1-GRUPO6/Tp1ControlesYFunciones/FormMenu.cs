using System;
using System.Windows.Forms;

namespace TpControlesYFunciones
{
    /// <summary>
    /// Pantalla inicial: permite abrir cada ejercicio del TP desde un único programa.
    /// </summary>
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            using (var form = new FormCalculadora())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            using (var form = new FormPassword())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            using (var form = new FormConversor())
            {
                form.ShowDialog(this);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
