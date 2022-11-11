using LibreriaEmpleado.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Cliente : Persona
    {
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        public Cliente(string cuit, string telefono, int id, string nombre, string apellido) : base(id, nombre, apellido)
        {
            Cuit = cuit;
            Telefono = telefono;
        }
    }
}
