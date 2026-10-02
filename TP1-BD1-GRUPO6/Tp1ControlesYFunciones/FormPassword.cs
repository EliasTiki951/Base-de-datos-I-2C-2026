using System;
using System.Drawing;
using System.Windows.Forms;

namespace TpControlesYFunciones
{
    // Ejercicio 2: evalúa la fortaleza de una contraseña en tiempo real (evento TextChanged)
    public partial class FormPassword : Form
    {
        private const string Debil = "Débil";
        private const string Media = "Media";
        private const string Fuerte = "Fuerte";

        public FormPassword()
        {
            InitializeComponent();
            lblEvaluacion.Text = string.Empty;
        }

        // true si la contraseña tiene al menos 8 caracteres.
        private bool EsLongitudValida(string pass)
        {
            return pass.Length >= 8;
        }

        //true si contiene al menos un dígito y al menos una letra mayúscula.
        private bool TieneNumeroYMayuscula(string pass)
        {
            bool tieneDigito = false;
            bool tieneMayuscula = false;

            foreach (char c in pass)
            {
                if (char.IsDigit(c)) tieneDigito = true;
                else if (char.IsUpper(c)) tieneMayuscula = true;
            }

            return tieneDigito && tieneMayuscula;
        }

        // "Fuerte" si cumple las dos reglas, "Media" si cumple una, "Débil" si no cumple ninguna.
        private string EvaluarNivelSeguridad(string pass)
        {
            int reglasCumplidas = 0;
            if (EsLongitudValida(pass)) reglasCumplidas++;
            if (TieneNumeroYMayuscula(pass)) reglasCumplidas++;

            if (reglasCumplidas == 2) return Fuerte;
            if (reglasCumplidas == 1) return Media;
            return Debil;
        }

        // Eventos
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                lblEvaluacion.Text = string.Empty;
                lblEvaluacion.BackColor = SystemColors.Control;
                return;
            }

            string nivel = EvaluarNivelSeguridad(txtPassword.Text);
            lblEvaluacion.Text = "Seguridad: " + nivel;

            switch (nivel)
            {
                case Debil:
                    lblEvaluacion.ForeColor = Color.Red;
                    lblEvaluacion.BackColor = Color.MistyRose;
                    break;
                case Media:
                    lblEvaluacion.ForeColor = Color.Orange;
                    lblEvaluacion.BackColor = Color.LemonChiffon;
                    break;
                case Fuerte:
                    lblEvaluacion.ForeColor = Color.Green;
                    lblEvaluacion.BackColor = Color.Honeydew;
                    break;
            }
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            // Con UseSystemPasswordChar = true se ocultan los caracteres; en false se ven.
            txtPassword.UseSystemPasswordChar = !chkMostrarPass.Checked;
        }
    }
}
