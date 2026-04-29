using Treca_Zadaca.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Treca_Zadaca.Repozitoriji
{
    public class RepozitorijZaposlenika
    {
        public static Zaposlenik GetZaposlenik(string username)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE Username='{username}'";
            return FetchZaposlenik(sql);
        }

        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM Zaposlenici WHERE Id = {id}";
            return FetchZaposlenik(sql);
        }
        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return zaposlenik;
        }
        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["id_zaposlenika"].ToString());
            string username = reader["username"].ToString();
            string password = reader["password"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                Username = username,
                Password = password
            };
            return zaposlenik;
        }
    }
}