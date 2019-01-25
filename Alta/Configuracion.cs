using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta
{
    public class Configuracion
    {
        public static IEscritorUsuario obtenerEstrategia(notificarError notificar) {
            return new EscritorUsuarioEjercicioPedido(
                new EscritorUsuarioTexto(),
                new EscritorUsuarioSQL(new Conexion().crearConexion(), notificar)
            );
        }
    }
}
