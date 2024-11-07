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

namespace proyecto12
{
    public partial class Form1 : Form
    {
        string archivo;
        FontStyle negritas = new FontStyle();
        FontStyle italica = new FontStyle();
        FontStyle subrayado = new FontStyle();
        FontStyle tachado = new FontStyle();    
        public Form1()
        {
            InitializeComponent();
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto|*.txt";
            if(archivo != null)
            {
                using (StreamWriter sw  = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);

                }
                MessageBox.Show("Se ha guardado bien el archivo " + archivo + " Correctamente", "Guardado", MessageBoxButtons.OK);

            }
            else
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                    MessageBox.Show("Se ha guardado el archivo " + saveFile.FileName + " Correctamente", "Guardado", MessageBoxButtons.OK);

                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") 
                Clipboard.SetDataObject(richTextBox1.SelectedText);
            
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            richTextBox1.Text = (string)iData.GetData(DataFormats.Text);
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
                richTextBox1.Cut();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (negritas == FontStyle.Bold)
                negritas = FontStyle.Regular;
            else
                negritas = FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, negritas | italica | subrayado | tachado);
        }

        private void italicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (italica == FontStyle.Italic)
                italica = FontStyle.Regular;
            else
                italica = FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, negritas | italica | subrayado | tachado);

        }

        private void subrayadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (subrayado == FontStyle.Underline)
                subrayado = FontStyle.Regular;
            else
                subrayado = FontStyle.Underline;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, negritas | italica | subrayado | tachado);

        }

        private void tachadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tachado == FontStyle.Strikeout)
                tachado = FontStyle.Strikeout;
            else
                tachado = FontStyle.Strikeout;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, negritas | italica | subrayado | tachado);

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void derechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void mayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();            
        }

        private void minusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }

        private void longitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                int num = richTextBox1.Text.Length;
                label1.Text += num.ToString();
            }
        }
    }
}
