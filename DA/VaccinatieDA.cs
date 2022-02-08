using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Vaccinatietool.Model;
using Vaccinatietool.Helper;
using System.Data;

namespace Vaccinatietool.DA
{
    public class VaccinatieDA
    {
        public static List<Vaccinatie> GetVaccinaties(Burger burger)
        {
            //Nieuwe lijst maken voor de vaccinaties van een burger
            List<Vaccinatie> vaccinaties = new List<Vaccinatie>();
            //Connectie met database + query
            string sql = "SELECT * FROM vaccinatie " +
                "INNER JOIN burger ON vaccinatie.burgerid = burger.burgerid " +
                "INNER JOIN vaccin ON vaccinatie.vaccinid = vaccin.vaccinid " +
                "WHERE vaccinatie.burgerid=@burgerid";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getVacs = new MySqlCommand(sql, conn);
            getVacs.Parameters.AddWithValue("@burgerid", burger.BurgerID);
            //Uitlezen resultaten
            MySqlDataReader reader = getVacs.ExecuteReader();
            while (reader.Read())
            {
                vaccinaties.Add(Create(reader));
            }
            conn.Close();
            reader.Close();
            return vaccinaties;
        }

        public static void SaveVaccinatie(Vaccinatie vaccinatie)
        {
            //BurgerDA.SaveBurger(vaccinatie.Burger);
            //Query opstellen + connectie maken
            string sql = "INSERT INTO vaccinatie (datum, burgerid, vaccinid, vaccinatorid)" +
                "VALUES (@datum, @burgerid, @vaccinid, @vaccinatorid)";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand addVacs = new MySqlCommand(sql, conn);
            addVacs.Parameters.AddWithValue("@datum", vaccinatie.Datum);
            addVacs.Parameters.AddWithValue("@burgerid", vaccinatie.Burger.BurgerID);
            addVacs.Parameters.AddWithValue("@vaccinid", vaccinatie.Vaccin.VaccinID);
            addVacs.Parameters.AddWithValue("@vaccinatorid", vaccinatie.Vaccinator.VaccinatorID);
            //Query uitvoeren
            addVacs.ExecuteNonQuery();
        }

        //Functie om object aan te maken
        public static Vaccinatie Create(IDataRecord record)
        {
            return new Vaccinatie()
            {
                VaccinatieID = Convert.ToInt32(record["vaccinatieid"].ToString()),
                Datum = Convert.ToDateTime(record["datum"].ToString()),
                Burger = BurgerDA.Create(record),
                Vaccin = VaccinDA.Create(record),
                Vaccinator = VaccinatorDA.Create(record)
            };
        }
    }
}
