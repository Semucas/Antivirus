using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Antivirus
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] secuencias = {
        "15301549", // Virus Usama
        "72721529", // Virus Amtrax
        "29325329", // Virus éBola
        "72323220", // Virus Ah1N1
        "30252019"  // Virus Covid19
    };

            List<string> virusDetectados = new List<string>();

            // Buscar coincidencias en el contenido hexadecimal
            foreach (string secuencia in secuencias)
            {
                if (textBox2.Text.Contains(secuencia))
                {
                    if (secuencia == "15301549")
                    {
                        virusDetectados.Add("Contiene el virus Usama.");
                    }
                    else if (secuencia == "72721529")
                    {
                        virusDetectados.Add("Contiene el virus Amtrax.");
                    }
                    else if (secuencia == "29325329")
                    {
                        virusDetectados.Add("Contiene el virus éBola.");
                    }
                    else if (secuencia == "72323220")
                    {
                        virusDetectados.Add("Contiene el virus Ah1N1.");
                    }
                    else if (secuencia == "30252019")
                    {
                        virusDetectados.Add("Contiene el virus Covid19.");
                    }
                }
            }

            // Mostrar los virus detectados
            if (virusDetectados.Count > 0)
            {
                textoVirus.Text = string.Join("\n", virusDetectados);
            }
            else
            {
                textoVirus.Text = "No contiene ningún virus.";
            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            // Crea un cuadro de diálogo para abrir archivos
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Establece las propiedades del cuadro de diálogo
            openFileDialog1.InitialDirectory = "c:\\"; // Directorio inicial
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*"; // Filtro de archivos
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Muestra el cuadro de diálogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtiene la ruta del archivo seleccionado
                    string filePath = openFileDialog1.FileName;

                    // Obtiene solo el nombre del archivo sin la ruta
                    string fileName = Path.GetFileName(filePath);

                    // Asigna la ruta del archivo al TextBox
                    textBox1.Text = "Nombre del archivo: " + fileName;


                    //Leyendo los bytes del archivo
                    byte[] bytes = File.ReadAllBytes(filePath);

                    // Convierte los bytes a una representación de cadena hexadecimal
                    string hexString = BitConverter.ToString(bytes).Replace("-", "");

                    // Asigna la cadena hexadecimal al TextBox2
                    textBox2.Text = hexString;

                    textoArchivo.Text = fileName;


                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir durante la lectura del archivo
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void textVirus_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
