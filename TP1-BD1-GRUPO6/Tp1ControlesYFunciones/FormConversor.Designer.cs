using System;
using System.Drawing;
using System.Windows.Forms;

namespace TpControlesYFunciones
{
    partial class FormConversor
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
            lblValor = new Label();
            numValor = new NumericUpDown();
            rbCelsToFahr = new RadioButton();
            rbFahrToCels = new RadioButton();
            btnConvertir = new Button();
            lblResumen = new Label();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            //
            // lblValor
            //
            lblValor.AutoSize = true;
            lblValor.Location = new Point(20, 23);
            lblValor.Name = "lblValor";
            lblValor.Text = "Valor a convertir:";
            //
            // numValor
            //
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(170, 20);
            numValor.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numValor.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numValor.Name = "numValor";
            numValor.Size = new Size(190, 27);
            numValor.TextAlign = HorizontalAlignment.Right;
            //
            // rbCelsToFahr
            //
            rbCelsToFahr.AutoSize = true;
            rbCelsToFahr.Checked = true;
            rbCelsToFahr.Location = new Point(20, 65);
            rbCelsToFahr.Name = "rbCelsToFahr";
            rbCelsToFahr.TabStop = true;
            rbCelsToFahr.Text = "Celsius → Fahrenheit";
            rbCelsToFahr.UseVisualStyleBackColor = true;
            //
            // rbFahrToCels
            //
            rbFahrToCels.AutoSize = true;
            rbFahrToCels.Location = new Point(20, 95);
            rbFahrToCels.Name = "rbFahrToCels";
            rbFahrToCels.Text = "Fahrenheit → Celsius";
            rbFahrToCels.UseVisualStyleBackColor = true;
            //
            // btnConvertir
            //
            btnConvertir.Location = new Point(20, 135);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(340, 38);
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += new EventHandler(btnConvertir_Click);
            //
            // lblResumen
            //
            lblResumen.BorderStyle = BorderStyle.FixedSingle;
            lblResumen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumen.Location = new Point(20, 190);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(340, 60);
            lblResumen.TextAlign = ContentAlignment.MiddleCenter;
            //
            // FormConversor
            //
            AcceptButton = btnConvertir;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(380, 270);
            Controls.Add(lblValor);
            Controls.Add(numValor);
            Controls.Add(rbCelsToFahr);
            Controls.Add(rbFahrToCels);
            Controls.Add(btnConvertir);
            Controls.Add(lblResumen);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConversor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ejercicio 3: Conversor de unidades";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblValor;
        private NumericUpDown numValor;
        private RadioButton rbCelsToFahr;
        private RadioButton rbFahrToCels;
        private Button btnConvertir;
        private Label lblResumen;
    }
}
