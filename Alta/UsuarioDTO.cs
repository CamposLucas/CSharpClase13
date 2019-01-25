using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta
{
    public class UsuarioDTO
    {
        public UsuarioDTO(String nombre, String Apellido) {
            Id = Guid.NewGuid().ToString();
            this.Nombre = nombre;
            this.Apellido = Apellido;
        }
        public String Id { get; }
        public String Nombre { get; }
        public String Apellido { get; }
        public String obtenerDatosSepComma(bool newLine = true) {
            return Nombre + "," + Apellido + "," + Id + ((newLine) ? "\r\n" : "");
        }
    }
}
