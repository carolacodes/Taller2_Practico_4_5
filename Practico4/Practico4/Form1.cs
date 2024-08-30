using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class formulario4 : Form
    {
        public formulario4()
        {
            InitializeComponent();
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtDesde.Text) || string.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos contengan solo números
            int desde, hasta;
            if (!int.TryParse(txtDesde.Text, out desde) || !int.TryParse(txtHasta.Text, out hasta))
            {
                MessageBox.Show("Por favor, ingrese solo números en los campos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar el ListBox y el Chart antes de agregar nuevos ítems
            listNumeros.Items.Clear();
            chartNumeros.Series["Series1"].Points.Clear();

            // Generar números y agregarlos al ListBox y al Chart
            for (int i = desde; i <= hasta; i++)
            {
                listNumeros.Items.Add(i);
                chartNumeros.Series["Series1"].Points.AddXY(i, i); // X e Y pueden ser el mismo valor para una línea simple
            }
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            FiltrarNumeros(Modulo: 0);
        }

        private void btnImpar_Click(object sender, EventArgs e)
        {
            FiltrarNumeros(Modulo: 1);
        }

        private void FiltrarNumeros(int Modulo)
        {

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtDesde.Text) || string.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos contengan solo números
            int desde, hasta;
            if (!int.TryParse(txtDesde.Text, out desde) || !int.TryParse(txtHasta.Text, out hasta))
            {
                MessageBox.Show("Por favor, ingrese solo números en los campos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar el ListBox y el Chart antes de agregar nuevos ítems
            listNumeros.Items.Clear();
            chartNumeros.Series["Series1"].Points.Clear();

            // Filtrar números según el Modulo (0 para pares, 1 para impares)
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == Modulo)
                {
                    listNumeros.Items.Add(i);
                    chartNumeros.Series["Series1"].Points.AddXY(i, i);
                }
            }
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtDesde.Text) || string.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos contengan solo números
            int desde, hasta;
            if (!int.TryParse(txtDesde.Text, out desde) || !int.TryParse(txtHasta.Text, out hasta))
            {
                MessageBox.Show("Por favor, ingrese solo números en los campos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar el ListBox y el Chart antes de agregar nuevos ítems
            listNumeros.Items.Clear();
            chartNumeros.Series["Series1"].Points.Clear();

            // Generar números primos y agregarlos al ListBox y al Chart
            for (int i = desde; i <= hasta; i++)
            {
                if (EsPrimo(i))
                {
                    listNumeros.Items.Add(i);
                    chartNumeros.Series["Series1"].Points.AddXY(i, i);
                }
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}

