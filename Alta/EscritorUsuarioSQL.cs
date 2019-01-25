using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alta
{
    class EscritorUsuarioSQL : IEscritorUsuario
    {
        private SqlConnection conexionSQL;
        private notificarError notificarError;

        public EscritorUsuarioSQL(SqlConnection sqlCon)
        {
            this.notificarError = z => { };
            this.conexionSQL = sqlCon;
        }
        public EscritorUsuarioSQL(SqlConnection sqlCon, notificarError notificarError) {
            this.conexionSQL = sqlCon;
            this.notificarError = notificarError;
        }
        public void escribirUsuario(UsuarioDTO usuario)
        {
            try
            {
                SqlCommand comando = conexionSQL.CreateCommand();
                comando.CommandText = "INSERT Cliente (Nombre, Apellido,ID) VALUES ('" + usuario.Nombre + "', '" + usuario.Apellido + "','" + usuario.Id + "')";
                comando.ExecuteNonQuery();
                Console.WriteLine("El registro se inserto correctamente");
            }
            catch
            {
                notificarError("El registro NO se inserto en SQL");
                throw;
            }
        }
    }
}
