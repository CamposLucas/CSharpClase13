using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Alta
{
    public class EscritorUsuarioTexto : IEscritorUsuario
    {
        public void escribirUsuario(UsuarioDTO usuario) {
            try
            {
                File.AppendAllText(@"C:\Users\EducaciónIT\Desktop\Alta\Cadena.txt",
                    usuario.obtenerDatosSepComma());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
