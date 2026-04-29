using DBLayer;
using Treca_Zadaca.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Treca_Zadaca.Repozitoriji
{
    public class RepozitorijMaterijala
    {
        public static Materijal GetMaterijal(int id)
        {
            Materijal materijal = null;

            string sql = $"SELECT * FROM Materijal WHERE id_materijala={id}";
            DB.OpenConnection();
            var reader= DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                materijal = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return materijal;   
        }
        public static List<Materijal> GetMaterijals()
        {
            var materijals = new List<Materijal>();
            string sql = "SELECT * FROM Materijal";
            DB.OpenConnection();
            var reader= DB.GetDataReader(sql);
            while (reader.Read())
            {
                Materijal materijal = CreateObject(reader);
                materijals.Add(materijal); ;
            }
            reader.Close();
            DB.CloseConnection();

            return materijals;
        }
        private static Materijal CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["id_materijala"].ToString());
            string vrsta = reader["vrsta_materijala"].ToString();
            int cijenapokg = int.Parse(reader["cijena_po_kg"].ToString());
            int kolicina = int.Parse(reader["kolicina"].ToString());

            var materijal = new Materijal
            {
                IdMaterijal = id,
                Vrsta = vrsta,
                CijenapoKg = cijenapokg,
                Kolicina = kolicina
            };
            return materijal;
        }
        public static int Delete(Materijal materijal)
        {
            string sqldelete = "DELETE FROM Materijal WHERE id_materijala = " + materijal.IdMaterijal;
            DB.OpenConnection();
            int rows = DB.ExecuteCommand(sqldelete);
            DB.CloseConnection();
            return rows;
        }
        public static int Add(Materijal materijal)
        {
            string sqlinsert = "";
            sqlinsert = "INSERT INTO Materijal (vrsta_materijala,cijena_po_kg,kolicina)" + "VALUES( '" + materijal.Vrsta + "', '" + materijal.CijenapoKg + "', '" +
                materijal.Kolicina + "')";
            DB.OpenConnection();
            int rows = DB.ExecuteCommand(sqlinsert);
            DB.CloseConnection();
            return rows;
        }
        public static int Update(Materijal materijal)
        {
            string sqlupdate = "";
            sqlupdate= "UPDATE Materijal SET  vrsta_materijala = '"
                + materijal.Vrsta + "', cijena_po_kg = '"
                + materijal.CijenapoKg + "', kolicina = '" + materijal.Kolicina +
                "' WHERE id_materijala = " + materijal.IdMaterijal;
            DB.OpenConnection();
            int rows = DB.ExecuteCommand(sqlupdate);
            DB.CloseConnection();
            return rows;
        }
    }
}
