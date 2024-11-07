using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Microsoft.VisualBasic;


namespace practica13
{
    public partial class Form2 : Form
    {
        ProductoService PS = new ProductoService();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = PS.MostrarProductos();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                double precio = double.Parse(textBox4.Text);
                int inventario = int.Parse(textBox5.Text);
                PS.InsertarProducto(textBox1.Text, textBox2.Text, textBox3.Text, precio, inventario);
                dataGridView1.DataSource = PS.MostrarProductos();
                MessageBox.Show("Articulo agregado con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            else
                MessageBox.Show("Ingrese los datos correctamente.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Obtén la celda seleccionada
                DataGridViewCell celdaSeleccionada = dataGridView1.SelectedCells[0];
                // Obtén el valor de la celda seleccionada
                int id = Convert.ToInt32(celdaSeleccionada.Value);
                PS.EliminarProducto(id);
                MessageBox.Show("Articulo eliminado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona la celda Id para eliminar el articulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = PS.MostrarProductos();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["id"].Index)
            {
                dataGridView1.BeginEdit(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string nombre = row.Cells["nombre"].Value.ToString();
                string desc = row.Cells["descripcion"].Value.ToString();
                string marca = row.Cells["marca"].Value.ToString();
                double precio = Convert.ToDouble(row.Cells["precio"].Value);
                int stock = Convert.ToInt32(row.Cells["inventario"].Value);
                PS.EditarProducto(nombre,desc,marca,precio,stock,id);
            }
            PS.MostrarProductos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
