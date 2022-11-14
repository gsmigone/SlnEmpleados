using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;
using static System.Windows.Forms.AxHost;

namespace WindowsEmpleados.Models
{
    public class AdminEmpleado
    {
        private DBEmpleadosContext context = new DBEmpleadosContext();

        public List<Empleado> Lista()
        {
            List<Empleado> lista = context.Empleados.ToList();
            return lista;
        }

      
        public int Insertar(Empleado empleado)
        {
            context.Empleados.Add(empleado);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
    }
}
