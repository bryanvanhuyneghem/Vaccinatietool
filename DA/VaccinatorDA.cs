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
    public class VaccinatorDA
    {
        public static List<Vaccinator> GetVaccinatoren()
        {
            //Nieuwe lijst maken voor de vaccinaties van een burger
            List<Vaccinator> vaccinator = new List<Vaccinator>();
            //Connectie met database + query
            string sql = "SELECT * FROM vaccinator";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getVacs = new MySqlCommand(sql, conn);
            //Uitlezen resultaten
            MySqlDataReader reader = getVacs.ExecuteReader();
            while (reader.Read())
            {
                vaccinator.Add(Create(reader));
            }
            conn.Close();
            reader.Close();
            return vaccinator;
        }
        public static Vaccinator GetVaccinator(string voornaam, string familienaam)
        {
            //Aanmaken vaccinator;
            Vaccinator vaccinator = new Vaccinator();
            //Connectie met database + query
            string sql = "SELECT * FROM vaccinator " +
                "WHERE voornaam=@voornaam AND familienaam=@familienaam";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getVacs = new MySqlCommand(sql, conn);
            getVacs.Parameters.AddWithValue("@voornaam", voornaam);
            getVacs.Parameters.AddWithValue("@familienaam", familienaam);
            //Uitlezen resultaten
            MySqlDataReader reader = getVacs.ExecuteReader();
            while (reader.Read())
            {
                vaccinator = Create(reader);
            }
            //Connectie db sluiten
            reader.Close();
            conn.Close();
            //Resultaat meegeven
            return vaccinator;
        }
        public static Vaccinator GetVaccinator(int id)
        {
            //Aanmaken vaccinator;
            Vaccinator vaccinator = new Vaccinator();
            //Connectie met database + query
            string sql = "SELECT * FROM vaccinator " +
                "WHERE vaccinatorid=@vaccinatorid";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getVacs = new MySqlCommand(sql, conn);
            getVacs.Parameters.AddWithValue("@vaccinatorid", id);
            //Uitlezen resultaten
            MySqlDataReader reader = getVacs.ExecuteReader();
            while (reader.Read())
            {
                vaccinator = Create(reader);
            }
            //Connectie db sluiten
            reader.Close();
            conn.Close();
            //Resultaat meegeven
            return vaccinator;
        }

        //Functie om object aan te maken
        public static Vaccinator Create(IDataRecord record)
        {
            return new Vaccinator()
            {
                VaccinatorID = Convert.ToInt32(record["vaccinatorid"].ToString()),
                Voornaam = record["voornaam"].ToString(),
                Familienaam = record["familienaam"].ToString()
            };
        }
    }
}
