using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Datos {
    class General {
        public SqlConnection Conectar() {
            SqlConnection sConnect = new SqlConnection();
            string sServidor;
            string sBD;

            try {
                sServidor = "LAPTOP-IT2IFF9L";
                sBD = "VO2MAX_CONTROL";
                //sConnect = new SqlConnection(@"Data Source=" + sServidor + ";Initial Catalog=" + sBD + ";Persist Security Info=True;User ID=sa;Password=spiderlio05");
                sConnect = new SqlConnection(@"Data Source=" + sServidor + ";Initial Catalog=" + sBD + ";Integrated Security=True");
            } catch (Exception ex) {

            }
            return sConnect;
        }
    }
}
