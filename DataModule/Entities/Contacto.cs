using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModule
{
    public class Contacto
    {
        [Key, Column("ContactoId"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactoId { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Departamento { get; set; }
    }
}
