using EJer1805.Data.DataAccess;
using Google.Protobuf.WellKnownTypes;
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
            int id = int.Parse(id1.Text);
            string nombre = tbnombre.Text;
            string raza = comboBoxraza.Text;
            int nivelpoder= (int)numericUpDownpoder.Value;
            DateTime fechaactual = DateTime.Now;
            string historiaper = textBoxhistoria.Text;
            int respuesta = personaje.CrearPersonaje(id,nombre, raza, nivelpoder, fechaactual, historiaper);
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
            int idPersonajeBuscar = int.Parse(id1.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count>0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelpoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime fechaactual = DateTime.Now;
                string historiaper = textBoxhistoria.Text;

                tbnombre.Text = nombre;
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

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btactualizar_Click(object sender, EventArgs e)
            {
                int id = int.Parse(id1.Text);
                string nombre = tbnombre.Text;
                string raza = comboBoxraza.Text;
                int nivelpoder = (int)numericUpDownpoder.Value;
                DateTime fechaactual = DateTime.Now;
                string historiaper = textBoxhistoria.Text;

                // Intentar actualizar el personaje
                int respuesta = personaje.actualizarpersonaje(id,nombre, raza, nivelpoder, fechaactual, historiaper);

                if (respuesta > 0)
                {
                    MessageBox.Show("Datos del personaje actualizados exitosamente");
                    dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos del personaje");
                }
            }

        private void btdelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id1.Text);
            int respuesta = personaje.deletepersonaje(id);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje eliminado exitosamente.");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("No se encontró el personaje con el ID proporcionado.");
            }
        }
    }
    }

