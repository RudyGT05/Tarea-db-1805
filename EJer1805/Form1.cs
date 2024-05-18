using EJer1805.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJer1805
{
    public partial class Form1 : Form
    {
        private PersonajeDB personaje;
        // Lista de razas
        private string[] razasDragonBall = {
    "Android",
    "Bio-Android",
    "Humana",
    "Humano",
    "Majin",
    "Namekuseijin",
    "Saiyajin",
    "Saiyajin/Humano",
    "Saiyajin/Saiyajin"
};
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personaje.PruebaConexion()) 
            {
                MessageBox.Show("Simona la mona");

            }
            else
            {
                MessageBox.Show("Nelson");
            }
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;

        }

        private void tbcrear_Click(object sender, EventArgs e)
        {
            string nombre = id.Text;
            string raza = comboBoxraza.Text;
            int nivelpoder= (int)numericUpDownpoder.Value;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelpoder);
            if (respuesta > 0)
            {
                MessageBox.Show("Creado con Exito");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes ();
            }
            else
            {
                MessageBox.Show("Malismo");
            }



            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxraza.Items.AddRange(razasDragonBall);
        }


        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(id.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count>0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelpoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                
                id.Text = nombre;
                comboBoxraza.Text = raza;
                numericUpDownpoder.Value = nivelpoder;

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           BuscarPorId();
        }

        private void id_Leave(object sender, EventArgs e)
        {
            BuscarPorId();
        }
    }
    }

