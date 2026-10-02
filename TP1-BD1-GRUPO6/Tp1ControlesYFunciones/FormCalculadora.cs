using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpControlesYFunciones {
    // Ejercicio 1: calcula el importe final de una venta según tipo de cliente y medio de pago.
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbTipoCliente.SelectedIndex = 0;   // "Regular" por defecto
            rbEfectivo.Checked = true;          // "Efectivo" por defecto
        }

        //Porcentaje de descuento: Regular 0%, Socio 10%, VIP 20%.
        private decimal CalcularPorcentajeDescuento(string tipoCliente)
        {
            switch (tipoCliente.ToLowerInvariant())
            {
                case "socio":
                    return 0.10m;
                case "vip":
                    return 0.20m;
                case "regular":
                default:
                    return 0.0m;
            }
        }

        //Convierte el porcentaje de descuento en un importe (monto * porcentaje).
        private decimal CalcularValorDescuento(decimal montoBase, decimal porcentaje)
        {
            return montoBase * porcentaje;
        }

        //Recargo del 5% si se paga con tarjeta; 0 en caso contrario.
        private decimal CalcularRecargoMedioPago(bool esTarjeta, decimal monto)
        {
            return esTarjeta ? monto * 0.05m : 0m;
        }

        //Monto final = base - descuento + recargo.
        private decimal ObtenerMontoFinal(decimal montoBase, decimal descuento, decimal recargo)
        {
            return montoBase - descuento + recargo;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1) Leer entradas
            string cliente = txtCliente.Text.Trim();
            decimal montoBase = numMonto.Value;
            string tipoCliente = cmbTipoCliente.SelectedItem?.ToString();
            bool esTarjeta = rbTarjeta.Checked; // Evalúa si la opción de tarjeta está seleccionada

            // 2) Validar
            if (cliente.Length == 0)
            {
                MessageBox.Show("Ingresá el nombre del cliente.", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tipoCliente))
            {
                MessageBox.Show("Seleccioná el tipo de cliente.", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoCliente.Focus();
                return;
            }
            if (montoBase <= 0)
            {
                MessageBox.Show("El monto base debe ser mayor a 0.", "Monto inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numMonto.Focus();
                return;
            }

            // 3) Invocar las funciones
            decimal porcentaje = CalcularPorcentajeDescuento(tipoCliente);
            decimal descuento  = CalcularValorDescuento(montoBase, porcentaje);
            decimal recargo    = CalcularRecargoMedioPago(esTarjeta, montoBase);
            decimal montoFinal = ObtenerMontoFinal(montoBase, descuento, recargo);

            // 4) Formatear y mostrar
            lblResultado.Text =
                $"Cliente: {cliente} ({tipoCliente})\n" +
                $"Medio de pago: {(esTarjeta ? "Tarjeta" : "Efectivo")}\n" +
                "\n" +
                $"Monto base: {montoBase:C2}\n" +
                $"Descuento ({porcentaje:P0}): -{descuento:C2}\n" +
                $"Recargo medio de pago:   +{recargo:C2}\n" +
                "------------------------------------\n" +
                $"TOTAL:   {montoFinal:C2}";
        }
    }
}
