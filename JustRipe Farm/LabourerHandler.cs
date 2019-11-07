using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipe_Farm
{
    public class LabourerHandler
    {
        public int addNewLabourer(MySqlConnection conn, Labourer labourer)
        {
            string sql = "INSERT INTO labourer (name, age, gender) " + " VALUES ('" + labourer.Name + "', " + labourer.Age + ", '" + labourer.Gender + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public List<Labourer> getAllLabourer(MySqlConnection conn)
        {
            List<Labourer> listOfLab = new List<Labourer>();

            // get from table
            // add to list
            string sql = "SELECT * FROM labourer ";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            //try
            //{
                MySqlDataReader reader;
                reader = sqlComm.ExecuteReader();

                while (reader.Read())
                {
                    Labourer aLabr = new Labourer();
                    aLabr.Id = (int)reader.GetValue(0);
                    aLabr.Name = (string)reader.GetValue(1);
                    aLabr.Age = (int)reader.GetValue(2);
                    aLabr.Gender = (string)reader.GetValue(3);

                    listOfLab.Add(aLabr);
                }
            //}
            //finally
            //{

            //}

            // return the list
            return listOfLab;
        }
    }
}
