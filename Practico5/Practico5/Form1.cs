using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Seleccionar Imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureUser.Image = Image.FromFile(openFileDialog.FileName);
                txtFoto.Text = openFileDialog.FileName;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                txtNombre.Text = char.ToUpper(txtNombre.Text[0]) + txtNombre.Text.Substring(1).ToLower();
                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length > 0)
            {
                txtApellido.Text = char.ToUpper(txtApellido.Text[0]) + txtApellido.Text.Substring(1).ToLower();
                txtApellido.SelectionStart = txtApellido.Text.Length;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int index = dataGridUser.Rows.Add();
            DataGridViewRow row = dataGridUser.Rows[index];

            


            row.Cells["Apellido"].Value = txtApellido.Text;
            row.Cells["Nombre"].Value = txtNombre.Text;
            row.Cells["Fecha_de_nacimiento"].Value = dateTimeUser.Value.ToShortDateString();
            row.Cells["Sexo"].Value = rbMujer.Checked ? "Mujer" : "Hombre";
            row.Cells["Saldo"].Value = txtSaldo.Text;

            
            if (pictureUser.Image != null)
            {
                row.Cells["Foto"].Value = pictureUser.Image;
                row.Cells["Ruta"].Value = txtFoto.Text;
            }
            else
            {
                
                string defaultImagePath = Path.Combine(Application.StartupPath, "Fotos", "user_7718888.png");
                Image defaultImage = Image.FromFile(defaultImagePath);
                row.Cells["Foto"].Value = Image.FromFile(defaultImagePath);
                row.Cells["Ruta"].Value = defaultImagePath;
            }

            
            DataGridViewButtonCell btnEliminar = new DataGridViewButtonCell();
            btnEliminar.Value = "Eliminar";
            row.Cells["Eliminar"] = btnEliminar;

            
            if (int.TryParse(txtSaldo.Text, out int saldo) && saldo < 50)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridUser.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridUser.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridUser.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridUser.SelectedRows[0];
                string sexo = selectedRow.Cells["Sexo"].Value.ToString();

                if (sexo == "Mujer")
                {
                    rbMujer.Checked = true;
                }
                else if (sexo == "Hombre")
                {
                    rbHombre.Checked = true;
                }

                
                if (selectedRow.Cells["Foto"].Value != null)
                {
                    pictureUser.Image = (Image)selectedRow.Cells["Foto"].Value;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridUser.Columns["Nombre"].DefaultCellStyle.Font = new Font("Papyrus", 12, FontStyle.Italic);
            dataGridUser.Columns["Apellido"].DefaultCellStyle.Font = new Font("Papyrus", 12, FontStyle.Bold);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //cancela la entrada de datos
            }
        }
    }
}
