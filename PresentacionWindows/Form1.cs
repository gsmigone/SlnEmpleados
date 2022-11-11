using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEmpleado.Models;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        Departamento departamento;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarDto_Click(object sender, EventArgs e)
        {
            departamento = new Departamento(Convert.ToInt32(txtIdDpto.Text), txtNombDpto.Text);
            MessageBox.Show("Departamento agregado!");
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            if (departamento != null)
            {
                departamento.Empleados.Add(new Empleado(txtLegEmpl.Text, departamento, Convert.ToInt32(txtIdEmpl.Text), txtNomEmpl.Text, txtApeEmpl.Text));
                MessageBox.Show("Empleado agregado!");
            }
            else
            {
                MessageBox.Show("ERROR: Primero debe crear un departamento!");
            }
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            if (departamento != null && departamento.Empleados != null)
            {
                gridEmpleados.DataSource = departamento.Empleados;
                
            }
            else
            {
                MessageBox.Show("ERROR: Primero debe cargar empleados!");
            }
        }
    }
}
