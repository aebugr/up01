using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Data
{
    class PartnersContext : Models.Partners
    {
        public PartnersContext(int idpartners, int type_partn, string company_name, string fio_director, string number_phone, int rayting, int skidka) 
            : base(idpartners, type_partn, company_name, fio_director, number_phone, rayting, skidka) { }
        public static List<PartnersContext> AllPartners()
        {
            List<PartnersContext> allPartners = new List<PartnersContext>();

            MySqlConnection connection = Classes.Connection.OpenConnection();
            MySqlDataReader partnerQuery = Classes.Connection.Query("SELECT * FROM up01.partners;", connection);
            while (partnerQuery.Read())
            {
                allPartners.Add(new PartnersContext(
                    partnerQuery.GetInt32(0),
                    partnerQuery.GetInt32(1),
                    partnerQuery.GetString(2),
                    partnerQuery.GetString(3),
                    partnerQuery.GetString(4),
                    partnerQuery.GetInt32(5),
                    partnerQuery.GetInt32(6)
                    ));
            }
            Classes.Connection.CloseConnection(connection);

            return allPartners;
        }
    }
}
