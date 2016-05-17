// Gestor de tareas
// Ventana de Retrasar Tarea (Windows Forms)

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.08   16-05-2016  Sacha Van de Sijpe, Carla Liarte, Cristian Navarrete
                      Primera versión de la ventana de Retrasar Tarea
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
    public partial class RetrasarTarea : Form
    {
        public RetrasarTarea()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
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
