using System;
using System.Drawing;
using System.Windows.Forms;

namespace TpControlesYFunciones
{
    partial class FormCalculadora
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
            lblCliente = new Label();
            lblMonto = new Label();
            lblTipo = new Label();
            lblPago = new Label();
            txtCliente = new TextBox();
            numMonto = new NumericUpDown();
            cmbTipoCliente = new ComboBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            btnCalcular = new Button();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();

            // lblCliente
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 23);
            lblCliente.Name = "lblCliente";
            lblCliente.Text = "Cliente:";
            
            // lblMonto
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(20, 63);
            lblMonto.Name = "lblMonto";
            lblMonto.Text = "Monto base:";
            
            // lblTipo
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(20, 103);
            lblTipo.Name = "lblTipo";
            lblTipo.Text = "Tipo de cliente:";
            
            // lblPago
            lblPago.AutoSize = true;
            lblPago.Location = new Point(20, 143);
            lblPago.Name = "lblPago";
            lblPago.Text = "Medio de pago:";
            
            // txtCliente
            txtCliente.Location = new Point(150, 20);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(230, 27);
            
            // numMonto
            numMonto.DecimalPlaces = 2;
            numMonto.Location = new Point(150, 60);
            numMonto.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(230, 27);
            numMonto.TextAlign = HorizontalAlignment.Right;
            numMonto.ThousandsSeparator = true;
            
            // cmbTipoCliente
            cmbTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Items.AddRange(new object[] { "Regular", "Socio", "VIP" });
            cmbTipoCliente.Location = new Point(150, 100);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(230, 28);
            
            // rbEfectivo
            rbEfectivo.AutoSize = true;
            rbEfectivo.Checked = true;
            rbEfectivo.Location = new Point(150, 141);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            
            // rbTarjeta
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(250, 141);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Text = "Tarjeta (+5%)";
            rbTarjeta.UseVisualStyleBackColor = true;
            
            // btnCalcular
            btnCalcular.Location = new Point(150, 180);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(230, 38);
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
            
            // lblResultado
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Font = new Font("Segoe UI", 10F);
            lblResultado.Location = new Point(20, 238);
            lblResultado.Name = "lblResultado";
            lblResultado.Padding = new Padding(8);
            lblResultado.Size = new Size(360, 170);
            lblResultado.Text = "";
            
            // FormCalculadora
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(400, 430);
            Controls.Add(lblCliente);
            Controls.Add(lblMonto);
            Controls.Add(lblTipo);
            Controls.Add(lblPago);
            Controls.Add(txtCliente);
            Controls.Add(numMonto);
            Controls.Add(cmbTipoCliente);
            Controls.Add(rbEfectivo);
            Controls.Add(rbTarjeta);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCalculadora";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ejercicio 1: Calculadora de descuentos";
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblCliente;
        private Label lblMonto;
        private Label lblTipo;
        private Label lblPago;
        private TextBox txtCliente;
        private NumericUpDown numMonto;
        private ComboBox cmbTipoCliente;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
