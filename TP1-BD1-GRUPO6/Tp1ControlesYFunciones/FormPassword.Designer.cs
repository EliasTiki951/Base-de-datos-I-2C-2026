using System;
using System.Drawing;
using System.Windows.Forms;

namespace TpControlesYFunciones
{
    partial class FormPassword
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblPass = new Label();
            txtPassword = new TextBox();
            chkMostrarPass = new CheckBox();
            lblEvaluacion = new Label();
            lblReglas = new Label();
            SuspendLayout();
            //
            // lblPass
            //
            lblPass.AutoSize = true;
            lblPass.Location = new Point(20, 23);
            lblPass.Name = "lblPass";
            lblPass.Text = "Contraseña:";
            //
            // txtPassword
            //
            txtPassword.Location = new Point(125, 20);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 27);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += new EventHandler(txtPassword_TextChanged);
            //
            // chkMostrarPass
            //
            chkMostrarPass.AutoSize = true;
            chkMostrarPass.Location = new Point(125, 57);
            chkMostrarPass.Name = "chkMostrarPass";
            chkMostrarPass.Text = "Mostrar contraseña";
            chkMostrarPass.UseVisualStyleBackColor = true;
            chkMostrarPass.CheckedChanged += new EventHandler(chkMostrarPass_CheckedChanged);
            //
            // lblEvaluacion
            //
            lblEvaluacion.AutoSize = false;
            lblEvaluacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEvaluacion.Location = new Point(20, 100);
            lblEvaluacion.Name = "lblEvaluacion";
            lblEvaluacion.Size = new Size(340, 45);
            lblEvaluacion.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblReglas
            //
            lblReglas.ForeColor = SystemColors.GrayText;
            lblReglas.Location = new Point(20, 160);
            lblReglas.Name = "lblReglas";
            lblReglas.Size = new Size(340, 50);
            lblReglas.Text = "Reglas: mínimo 8 caracteres, y al menos un número y una letra mayúscula.";
            //
            // FormPassword
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(380, 220);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(chkMostrarPass);
            Controls.Add(lblEvaluacion);
            Controls.Add(lblReglas);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ejercicio 2: Validador de contraseñas";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPass;
        private TextBox txtPassword;
        private CheckBox chkMostrarPass;
        private Label lblEvaluacion;
        private Label lblReglas;
    }
}
