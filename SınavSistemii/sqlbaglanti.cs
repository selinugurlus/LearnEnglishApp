using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SınavSistemii
{

    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
