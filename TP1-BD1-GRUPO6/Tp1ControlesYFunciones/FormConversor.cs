using System;
using System.Windows.Forms;

namespace TpControlesYFunciones
{
    // Ejercicio 3: conversor de temperatura. La función devuelve una tupla
    // (resultado numérico, texto descriptivo).
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
            rbCelsToFahr.Checked = true;
        }

        // Función de lógica: devuelve DOS valores mediante una tupla
        private (decimal resultado, string etiqueta) ConvertirTemperatura(decimal valor, bool celsiusAFahrenheit)
        {
            if (celsiusAFahrenheit)
            {
                decimal fahrenheit = valor * 9m / 5m + 32m;
                return (fahrenheit, $"{valor:N2} °C = {fahrenheit:N2} °F  (Celsius a Fahrenheit)");
            }
            else
            {
                decimal celsius = (valor - 32m) * 5m / 9m;
                return (celsius, $"{valor:N2} °F = {celsius:N2} °C  (Fahrenheit a Celsius)");
            }
        }

        // Evento
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            var (_, etiqueta) = ConvertirTemperatura(numValor.Value, rbCelsToFahr.Checked);
            lblResumen.Text = etiqueta;
        }
    }
}
