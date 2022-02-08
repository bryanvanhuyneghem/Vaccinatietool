using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Vaccinatietool.Helper;
using Vaccinatietool.Model;

namespace Vaccinatietool.DA
{
    public class VaccinDA
    {
        public static List<Vaccin> GetVaccins()
        {
            //Nieuwe lijst maken voor de vaccinaties van een burger
            List<Vaccin> vaccins = new List<Vaccin>();
            //Connectie met database + query
            string sql = "SELECT * FROM vaccin";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getVacs = new MySqlCommand(sql, conn);
            //Uitlezen resultaten
            MySqlDataReader reader = getVacs.ExecuteReader();
            while (reader.Read())
            {
                vaccins.Add(Create(reader));
            }
            conn.Close();
            reader.Close();
            return vaccins;
        }
        public static Vaccin GetVaccin(int id)
        {
            //Aanmaken vaccin;
            Vaccin vac = new Vaccin();
            //Connectie met database + query
            string sql = "SELECT * FROM vaccin " +
                "WHERE vaccinid=@vaccinid";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getVacs = new MySqlCommand(sql, conn);
            getVacs.Parameters.AddWithValue("@vaccinid", id);
            //Uitlezen resultaten
            MySqlDataReader reader = getVacs.ExecuteReader();
            while (reader.Read())
            {
                vac = Create(reader);
            }
            //Connectie db sluiten
            reader.Close();
            conn.Close();
            //Resultaat meegeven
            return vac;
        }

        public static Vaccin GetVaccin(string naam)
        {
            //Aanmaken vaccin;
            Vaccin vac = new Vaccin();
            //Connectie met database + query
            string sql = "SELECT * FROM vaccin " +
                "WHERE naam=@naam";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getVacs = new MySqlCommand(sql, conn);
            getVacs.Parameters.AddWithValue("@naam", naam);
            //Uitlezen resultaten
            MySqlDataReader reader = getVacs.ExecuteReader();
            while (reader.Read())
            {
                vac = Create(reader);
            }
            //Connectie db sluiten
            reader.Close();
            conn.Close();
            //Resultaat meegeven
            return vac;
        }

        public static Vaccin Create(IDataRecord record)
        {
            return new Vaccin()
            {
                VaccinID = Convert.ToInt32(record["vaccinid"].ToString()),
                Naam = record["naam"].ToString(),
                Producent = record["producent"].ToString(),
                Type = record["type"].ToString()
            };
        }
    }
}
