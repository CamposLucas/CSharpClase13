using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta
{
    public class EstrategiaNueva : IEscritorUsuario
    {
        IEscritorUsuario txt = null;
        IEscritorUsuario sql = null;
        private UltimaSession us = new UltimaSession();

        public EstrategiaNueva(
            IEscritorUsuario txt, IEscritorUsuario sql)
        {
            this.txt = txt;
            this.sql = sql;
        }        
        public void escribirUsuario(UsuarioDTO usuario)
        {
            enTxt(usuario);
            enSQL(usuario);
        }
        private void enTxt(UsuarioDTO usuario)
        {
            try
            {
                txt.escribirUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void enSQL(UsuarioDTO usuario)
        {
            if (us.huboTransacEnUltimoMinuto())
            {
                return;
            }

            try
            {
                us.marcarTransac();
                sql.escribirUsuario(usuario);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
