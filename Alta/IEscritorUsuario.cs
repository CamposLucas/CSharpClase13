using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta
{
    public delegate void notificarError(string mensaje);

    public interface IEscritorUsuario
    {
        void escribirUsuario(UsuarioDTO usuario);
    }
}
