using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    [Table("Departamento")]
    public class Departamento
    {

        [Required]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]// tipo de datos de sql server
        [StringLength(50)]
        public string Nombre { get; set; }
        
        public int IdEmpleado { get; set; }


        public List<Empleado> Empleados { get; set; }

        public Departamento(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Empleados = new List<Empleado>();
        }

    }
}
