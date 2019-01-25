using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta
{
    public class UltimaSession
    {
        private DateTime ultimo = new DateTime(2019,1,1);
        public UltimaSession() {            
        }
        public void marcarTransac() {
            ultimo = DateTime.Now;
        }
        public bool huboTransacEnUltimoMinuto() {
            TimeSpan ts = DateTime.Now - ultimo;
            if (ts.TotalSeconds < 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
