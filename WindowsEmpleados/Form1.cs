using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsEmpleados.Models;
using LibreriaEmpleado.Models;
using System.Runtime.Remoting.Contexts;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
        AdminEmpleado admin = new AdminEmpleado();
        Departamento departamento = new Departamento(1, "Depto");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            int filasAfectadas = admin.Insertar(new Empleado(txtLegEmpl.Text, departamento, Convert.ToInt32(txtIdEmpl.Text), txtNomEmpl.Text, txtApeEmpl.Text));
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Empleado agregado correctamente");
            }
            
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            if (departamento != null && departamento.Empleados != null)
            {
                gridEmpleados.DataSource = admin.Lista();

            }
            else
            {
                MessageBox.Show("ERROR: Primero debe cargar empleados!");
            }
        }
    }
}
