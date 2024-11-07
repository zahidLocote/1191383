using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace tarea15P
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int num = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private async Task<pokemon> GetPokemonData(string pokemonName)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";
            var response = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<pokemon>(response);
        }
        private async Task LoadPokemon(int num)
        {
            try
            {
                string NUM = num.ToString();
                var pokemon = await GetPokemonData(NUM);
                pictureBox3.Load(pokemon.Sprites.Front_Default);
                label1.Text = "Nombre: " + pokemon.Name;
                label2.Text = "Numero de pokemon: " + pokemon.Id.ToString();
                string tipos = string.Join(", ", pokemon.Types.Select(t => t.Type.Name));
                label3.Text = $"Tipo(s): {tipos}";
                double peso = pokemon.weight / 10.0;
                double altura = pokemon.height / 10.0;
                label4.Text = "Peso: " + peso + " kg" + " Altura: " + altura + "m";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async Task LoadPokemon(string nom)
        {
            try
            {
                var pokemon = await GetPokemonData(nom);
                pictureBox3.Load(pokemon.Sprites.Front_Default);
                label1.Text = "Nombre: " + pokemon.Name;
                num = pokemon.Id;
                label2.Text = "Numero de pokemon: " + pokemon.Id.ToString();
                string tipos = string.Join(", ", pokemon.Types.Select(t => t.Type.Name));
                label3.Text = $"Tipo(s): {tipos}";
                double peso = pokemon.weight / 10.0;
                double altura = pokemon.height / 10.0;
                label4.Text = "Peso: " + peso + " kg" + " Altura: " + altura + "m";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: No se encontró el Pokémon '{nom}'. {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox3.BackColor = Color.OliveDrab;
                pictureBox4.BackColor = Color.OliveDrab;
                pictureBox2.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;

                string NUM = num.ToString();
                var pokemon = await GetPokemonData(NUM);
                pictureBox3.Load(pokemon.Sprites.Front_Default);
                label1.Visible = true;
                label1.Text = "Nombre: " + pokemon.Name;
                label2.Visible = true;
                label2.Text = "Numero de pokemon: " + pokemon.Id.ToString();
                label3.Visible = true;
                string tipos = string.Join(", ", pokemon.Types.Select(t => t.Type.Name));
                label3.Text = $"Tipo(s): {tipos}";
                label4.Visible = true;
                double peso = pokemon.weight / 10.0;
                double altura = pokemon.height / 10.0;
                label4.Text = "Peso: " + peso + " kg" + " Altura: " + altura + "m";
                button2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            num++;
            LoadPokemon(num);
            textBox1.Visible = false;
            button1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {}

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            num--;
            LoadPokemon(num);
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Buscar pokemon.";
            button1.Visible = true;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.ToLower();
            if (!string.IsNullOrEmpty(nombre))
            {
                await LoadPokemon(nombre);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre de Pokémon.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void toolStripComboBox1_Click(object sender, EventArgs e)
        {}

        private async void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {}

        private async void raToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPokemon(1);
            num = 1;
        }

        private async void daToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPokemon(152);
            num = 152;
        }

        private async void raToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            await LoadPokemon(252);
            num = 252;
        }

        private async void taToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPokemon(387);
            num = 387;
        }

        private async void taToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            await LoadPokemon(494);
            num = 495;
        }

        private async void taToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            await LoadPokemon(650);
            num = 650;
        }

        private async void maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPokemon(722);
            num = 722;
        }

        private async void vaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPokemon(810);
            num = 810;
        }

        private async void naToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPokemon(906);
            num = 906;
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            string NUM = num.ToString();
            var pokemon = await GetPokemonData(NUM);
            pictureBox3.Load(pokemon.Sprites.Front_Shiny);
        }
    }
}
