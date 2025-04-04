using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDB.Model
{
    class Social
    {
        public Social() { }

        public Social(int idsocial, string? nombre, string? apellido, string? arcana, string? persona, string? grupo)
        {
            this.idsocial = idsocial;
            this.nombre = nombre;
            this.apellido = apellido;
            this.arcana = arcana;
            this.persona = persona;
            this.grupo = grupo;

        }

        public int idsocial { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? arcana { get; set; }
        public string? persona { get; set; }
        public string? grupo { get; set; }
    }
}
