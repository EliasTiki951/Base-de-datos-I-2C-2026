using System;
using System.Drawing;
using System.Windows.Forms;

namespace TpControlesYFunciones
{
    partial class FormMenu
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
            lblTitulo = new Label();
            btnEjercicio1 = new Button();
            btnEjercicio2 = new Button();
            btnEjercicio3 = new Button();
            lblText = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(43, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(374, 66);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tp1: Controles y funciones\nC# escritorio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEjercicio1
            // 
            btnEjercicio1.Location = new Point(71, 88);
            btnEjercicio1.Name = "btnEjercicio1";
            btnEjercicio1.Size = new Size(321, 53);
            btnEjercicio1.TabIndex = 1;
            btnEjercicio1.Text = "Ejercicio 1: Calculadora de descuentos";
            btnEjercicio1.UseVisualStyleBackColor = true;
            btnEjercicio1.Click += btnEjercicio1_Click;
            // 
            // btnEjercicio2
            // 
            btnEjercicio2.Location = new Point(71, 159);
            btnEjercicio2.Name = "btnEjercicio2";
            btnEjercicio2.Size = new Size(321, 53);
            btnEjercicio2.TabIndex = 2;
            btnEjercicio2.Text = "Ejercicio 2: Validador de contraseñas";
            btnEjercicio2.UseVisualStyleBackColor = true;
            btnEjercicio2.Click += btnEjercicio2_Click;
            // 
            // btnEjercicio3
            // 
            btnEjercicio3.Location = new Point(71, 228);
            btnEjercicio3.Name = "btnEjercicio3";
            btnEjercicio3.Size = new Size(321, 53);
            btnEjercicio3.TabIndex = 3;
            btnEjercicio3.Text = "Ejercicio 3: Conversor de unidades";
            btnEjercicio3.UseVisualStyleBackColor = true;
            btnEjercicio3.Click += btnEjercicio3_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 12F);
            lblText.Location = new Point(80, 296);
            lblText.Name = "lblText";
            lblText.Size = new Size(298, 112);
            lblText.TabIndex = 4;
            lblText.Text = "INTEGRANTES:\n• Elias Tiquicala   Leg. 15034\n• Lautaro Reynaga   Leg. 15025\n• María Rosa Bianchi   Leg. 15006";
            lblText.Click += label1_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(466, 427);
            Controls.Add(lblText);
            Controls.Add(lblTitulo);
            Controls.Add(btnEjercicio1);
            Controls.Add(btnEjercicio2);
            Controls.Add(btnEjercicio3);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TP Controles y Funciones";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Button btnEjercicio1;
        private Button btnEjercicio2;
        private Button btnEjercicio3;
        private Label lblText;
    }
}
