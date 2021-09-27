using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventarEchipament
{
    class GetAngajat
    {
        public string GetSAP(string input)
        {
            string temporary = "";

            DataBase databaseObject = new DataBase();
            string query = "SELECT * from Angajati WHERE CodSAP=@CodSAP";

            SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

            myCommand.Parameters.AddWithValue("@CodSAP", input);

            databaseObject.OpenConnection();

            SqlDataReader re = myCommand.ExecuteReader();
            if (re.HasRows)
            {
                while (re.Read())
                {
                    temporary = re[1].ToString();
                }
            }
            else
            {
                temporary = "";
            }
           // temporary = (string)myCommand.ExecuteScalar().ToString();

            databaseObject.CloseConnection();

            return temporary;
        }

        public string GetIdAngajat(string input)
        {
            string temporary = "";

            DataBase databaseObject = new DataBase();
            string query = "SELECT * from Angajati WHERE CodSAP=@CodSAP";

            SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

            myCommand.Parameters.AddWithValue("@CodSAP", input);

            databaseObject.OpenConnection();

            SqlDataReader re = myCommand.ExecuteReader();
            if (re.HasRows)
            {
                while (re.Read())
                {
                    temporary = re[0].ToString();
                }
            }
            else
            {
                temporary = "";
            }
            // temporary = (string)myCommand.ExecuteScalar().ToString();

            databaseObject.CloseConnection();

            return temporary;
        }
    }
}
