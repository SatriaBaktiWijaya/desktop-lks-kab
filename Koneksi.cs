using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lks
{
    class Koneksi
    {
        public static SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HVFS6T5;Initial Catalog=lks;Integrated Security=True");
    }
}
