// Gestor de tareas
// Ventana principal (Windows Forms)

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.09   16-05-2016  Pablo Padilla, Manuel Coronado, Victor Carretero 
                      Primera versión de la ventana principal
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public int dia;
        public int mes;
        public int anyo;

        DateTime fecha = DateTime.Now;
        
        public Form1()
        {
            DateTime fecha = DateTime.Now;
            dia = fecha.Day;
            mes = fecha.Month;
            anyo = fecha.Year;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listaTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bAnyadirTarea_Click(object sender, EventArgs e)
        {
            VentanaTarea vt = new VentanaTarea();
            vt.ShowDialog();
        }

        private void bModificarTarea_Click(object sender, EventArgs e)
        {
            VentanaTarea vt = new VentanaTarea();
            vt.ShowDialog();
        }

        private void bRetrasarTarea_Click(object sender, EventArgs e)
        {
            RetrasarTarea rt = new RetrasarTarea();
            rt.ShowDialog();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            string message = "¿Está seguro?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string caption = "¿Está seguro?";
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
