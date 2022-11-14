using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.ModelsBase
{
    [Table("Persona")]
    public abstract class Persona
    {
        [Required]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]// tipo de datos de sql server
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]// tipo de datos de sql server
        [StringLength(50)]
        public string Apellido { get; set; }

        protected Persona(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
