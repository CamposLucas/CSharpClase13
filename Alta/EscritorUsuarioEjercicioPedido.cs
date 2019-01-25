using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta
{
    class EscritorUsuarioEjercicioPedido  : IEscritorUsuario
    {
        IEscritorUsuario txt = null;
        IEscritorUsuario sql = null;

        public EscritorUsuarioEjercicioPedido(
            IEscritorUsuario txt, IEscritorUsuario sql) {

            this.txt = txt;
            this.sql = sql;
        }
        public void escribirUsuario(UsuarioDTO usuario) {
            try
            {
                txt.escribirUsuario(usuario);
            }
            catch (Exception ex) {
                throw;
            }

            try {
                sql.escribirUsuario(usuario);
            }
            catch (Exception ex)
            {   
            }
        }
    }
}
