using LibreriaEmpleado.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Empleado : Persona
    {
        public string Legajo { get; set; }
        public Departamento Departamento { get; set; }
        public Empleado(string legajo, Departamento departamento, int id, string nombre, string apellido) : base(id, nombre, apellido)
        {
            Legajo = legajo;
            Departamento= departamento;
        }
    }
}
