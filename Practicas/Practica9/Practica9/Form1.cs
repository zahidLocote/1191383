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

namespace Practica9
{
    public partial class Form1 : Form
    {
        List<consola> list = new List<consola>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        async Task Main()
        {
            string apiURL = "https://jsonplaceholder.typicode.com/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        list = JsonConvert.DeserializeObject<List<consola>>(jsonContent);
                        dataGridView1.DataSource = list;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
