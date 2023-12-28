using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerenciaPersona;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;

namespace Taller1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona p1 = new Persona("Pablo", "Martinez", 27, "Masculino");
            Persona p2 = new Persona("Andres", "Cordoba", 25, "Masculino");
            Persona p3 = new Persona("Andrea", "Rodriguez", 26, "Femenino");
            Persona p4 = new Persona("Diana", "Oña", 28, "Femenino");
            Persona p5 = new Persona("Carla", "Perez", 29, "Femenino");
            Persona p6 = new Persona("Bella", "Hidalgo", 30, "Femenino");


            listBox1.Items.Add(p1);
            listBox1.Items.Add(p2);
            listBox1.Items.Add(p3);
            listBox1.Items.Add(p4);
            listBox1.Items.Add(p5);
            listBox1.Items.Add(p6);


            Genero.Items.Add("Masculino");
            Genero.Items.Add("Femenino");

         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona P1 = (Persona)listBox1.SelectedItem;

            textBox1.Text = P1.Nombre.ToString();
            textBox2.Text = P1.Apellido.ToString();
            textBox3.Text = P1.NIF.ToString();

            if (P1.Genero.Equals("Masculino"))
            {
                pictureBox1.Image = Image.FromFile("masculino.PNG");

            }
            if (P1.Genero.Equals("Femenino"))
            {
                pictureBox1.Image = Image.FromFile("Femenino.PNG");

            }

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = (string)Genero.SelectedItem;
            ListaPersona personas = new ListaPersona();
            foreach (Persona persona in listBox1.Items)
            {

                if (persona.Genero.Equals((string)Genero.SelectedItem))
                {
                    
                    personas.agregarPersona(persona);

                }
            }

            listBox1.Items.Clear();
            foreach (Persona p1 in personas.GetlistaP() )
            {
                listBox1.Items.Add(p1);
            }
            
        }

        
    }
}
    