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
    public class BurgerDA
    {
        public static bool BurgerExists(string voornaam, string familienaam)
        {
            string sql = "SELECT COUNT(*) FROM burger " +
                "WHERE voornaam=@voornaam AND familienaam=@familienaam";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getBurger = new MySqlCommand(sql, conn);
            getBurger.Parameters.AddWithValue("@voornaam", voornaam);
            getBurger.Parameters.AddWithValue("@familienaam", familienaam);
            if (Convert.ToInt16(getBurger.ExecuteScalar()) == 1)
            {
                return true;
                
            } else
            {
                return false;
            }
        }
        public static Burger GetBurger(string voornaam, string familienaam)
        {
            Burger burger = new Burger
            {
                Voornaam = voornaam,
                Familienaam = familienaam
            };
            if (!BurgerExists(voornaam, familienaam)) 
            {
                SaveBurger(burger);
            }
            
            //Connectie met database + query
            string sql = "SELECT burgerid FROM burger " +
                "WHERE voornaam=@voornaam AND familienaam=@familienaam";
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand getBurger = new MySqlCommand(sql, conn);
            getBurger.Parameters.AddWithValue("@voornaam", voornaam);
            getBurger.Parameters.AddWithValue("@familienaam", familienaam);
            //Uitlezen resultaten
            MySqlDataReader reader = getBurger.ExecuteReader();
            while (reader.Read())
            {
                burger.BurgerID = reader.GetInt32(0);
                burger.Voornaam = voornaam;
                burger.Familienaam = familienaam;
            }
            reader.Close();
            conn.Close();
            //Resultaat meegeven
            return burger;
        }

        public static void SaveBurger(Burger burger)
        {
                //Query opstellen + connectie maken
                string sql = "INSERT INTO burger (voornaam, familienaam)" +
                    "VALUES (@voornaam, @familienaam)";
                MySqlConnection conn = Database.MakeConnection();
                MySqlCommand addVacs = new MySqlCommand(sql, conn);
                addVacs.Parameters.AddWithValue("@voornaam", burger.Voornaam);
                addVacs.Parameters.AddWithValue("@familienaam", burger.Familienaam);
                //Query uitvoeren
                addVacs.ExecuteNonQuery();
        }

        //Functie om object aan te maken
        public static Burger Create(IDataRecord record)
        {
            return new Burger()
            {
                BurgerID = Convert.ToInt32(record["burgerid"].ToString()),
                Voornaam = record["voornaam"].ToString(),
                Familienaam = record["familienaam"].ToString()
            };
        }
    }
}
