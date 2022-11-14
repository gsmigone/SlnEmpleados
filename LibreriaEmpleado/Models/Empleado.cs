using LibreriaEmpleado.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    [Table("Empleado")]
    public class Empleado : Persona
    {
        [Required]
        [Column(TypeName = "varchar")]// tipo de datos de sql server
        [StringLength(50)]
        public string Legajo { get; set; }

        public int IdDepartamento { get; set; }

        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }
        public Empleado(string legajo, Departamento departamento, int id, string nombre, string apellido) : base(id, nombre, apellido)
        {
            Legajo = legajo;
            Departamento= departamento;
        }
    }
}
