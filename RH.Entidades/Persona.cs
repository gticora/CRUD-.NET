using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Entidades
{

        [Table("Persona")]
        public class Persona
        {


            [Column("IdPersona"), Key]
            public int IdPersona { get; set; }

            [Column("Nombre")]
            public string Nombre { get; set; }

            [Column("Apellido")]
            public string Apellido { get; set; }

            [Column("Telefono")]
            public string Telefono { get; set; }

        }
    
}
