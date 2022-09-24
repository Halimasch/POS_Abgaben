using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fußball_Lib
{
    public enum PlayerPosition { Goalkeeper = 0, Defender = 1, Midfield = 2, Forward =3 };

    public class DAL
    {
        private SqlConnection _Con;
        private string _Path;

        public DAL()
        {
            _Path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicolas\OneDrive\Dokumente\Spieler.mdf;Integrated Security=True;Connect Timeout=30";
            _Con = new SqlConnection(_Path);
        }

        public List<Player> LoadAllPlayersDB()
        {
            List<Player> list = new List<Player>();

            try
            {
                _Con.Open();
                string selectStr = "SELECT * FROM [Table]";
                SqlCommand cmd = new SqlCommand(selectStr, _Con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["PlayerID"]);
                    string name = reader["Name"].ToString();
                    string street = reader["Street"].ToString();
                    string city = reader["City"].ToString();
                    int zip = Convert.ToInt32(reader["ZIP"]);
                    string position = reader["Position"].ToString();
                    int bonus = Convert.ToInt32(reader["Bonus"]);

                    Address adresse = new Address { Street = street, ZIP = zip, City = city };
                    Player player = new Player { ID = id, Name = name, Adresse = adresse, Position = position, Bonus = bonus };

                    list.Add(player);
                }
            }
            catch (SqlException exe)
            {
                Console.WriteLine(exe.Message);
            }
            finally
            {
                _Con.Close();
            }
            return list;
        }

        // Insert into DB kommt nicht 
        //public void AddPlayer(int id, string name, string pos, string adr, string bon)
        //{
        //    try
        //    {
        //        _Con.Open();
        //        string insertStr = "INSERT INTO [Table]";
        //    }
        //    catch (SqlException exe)
        //    {
        //        Console.WriteLine(exe.Message);
        //    }
        //    finally
        //    {
        //        _Con.Close();
        //    }
        //}

        //public List<string> PlayerPositionsDAL()
        //{
        //    List<string> list = new List<string>();
        //    list = PlayerPosition.


        //    return list;
        //}



    }
}
