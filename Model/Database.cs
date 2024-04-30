using System;
using MySqlConnector;

namespace ServiceOne.Model
{
  public class Database
  {
    private static string connStr = "server=127.0.0.1;database=serviceone;user=root;password= ;";
    private static MySqlConnection connection;
    private static string sql = "";
    private static MySqlCommand command;

    public static void ConnectServer()
    {
      try
      {
        string connStrNoDB = "server=127.0.0.1;database=;user=root;password= ;";
        connection = new MySqlConnection(connStrNoDB);
        connection.Open();
        Console.WriteLine("ok");
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
    }

    public static void ConnectDatabase()
    {
      try
      {
        connection = new MySqlConnection(connStr);
        connection.Open();
        Console.WriteLine("Verbunden!");
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
    }

    public static void CreateDatabase(string database)
    {
      ConnectServer();

      sql = "CREATE DATABASE IF NOT EXISTS " + database + " ;";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();
      connection.Dispose();
    }

    public static void DropDatabase(string database)
    {
      ConnectServer();

      sql = "DROP DATABASE " + database + " ;";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();
      connection.Dispose();
    }

    public static void CreateTables()
    {
      ConnectDatabase();
      
      sql = "CREATE TABLE IF NOT EXISTS artikelkategorien" +
            "(" +
            "KategorieID int AUTO_INCREMENT PRIMARY KEY," +
            "Kategoriename varchar(255)," +
            "Beschreibung int(70)" +
            ")" +
            ";";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();
      
      sql = "CREATE TABLE IF NOT EXISTS artikel" +
            "(" +
            "ArtikelID int PRIMARY KEY," +
            "MaterialNr int(11)," +
            "Artikelname varchar(70)," +
            "Beschreibung longtext," +
            "Einzelpreis decimal(19,2)," +
            "KategorieNr int(11)," +
            "Bild varchar(255)," +
            "CONSTRAINT fkArtikelkattegorienArtikel FOREIGN KEY (KategorieNr)" +
            "REFERENCES artikelkategorien (KategorieID)" +
            ")" +
            ";";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();

      sql = "CREATE TABLE IF NOT EXISTS kunden" +
            "(" +
            "KundenID int AUTO_INCREMENT PRIMARY KEY," +
            "Firma varchar(255)," +
            "Vorname varchar(255)," +
            "Nachname varchar(255)," +
            "Strasse varchar(255)," +
            "PLZ varchar(255)," +
            "Ort varchar(255)," +
            "Email varchar(255)," +
            "Telefon varchar(255)," +
            "Rabatt decimal(19,2)" +
            ")" +
            ";";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();

      sql = "CREATE TABLE IF NOT EXISTS techniker" +
            "(" +
            "TechnikerID int AUTO_INCREMENT PRIMARY KEY," +
            "Vorname varchar(255)," +
            "Nachname varchar(255)," +
            "KFZ varchar(255)" +
            ")" +
            ";";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();

      sql = "CREATE TABLE IF NOT EXISTS bestellungen" +
            "(" +
            "BestellID int AUTO_INCREMENT PRIMARY KEY," +
            "KundenNr int(11)," +
            "Datum datetime(6)," +
            "CONSTRAINT fkKundenBestellungen FOREIGN KEY (KundenNr)" +
            "REFERENCES Kunden (KundenID)" +
            ")" +
            ";";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();
      
      sql = "CREATE TABLE IF NOT EXISTS bestellungendetails" +
            "(" +
            "BestellNr int(11)," +
            "TechnikerNr int(11)," +
            "ArtikelNr int(11)," +
            "Anzahl int(11)," +
            "PRIMARY KEY (BestellNr, TechnikerNr)," +
            "CONSTRAINT fkBestellungenBestellungsdetails FOREIGN KEY(BestellNr)" +
            "REFERENCES bestellungen (BestellID)," +
            "CONSTRAINT fkTechnikerBestellungsdetails FOREIGN KEY (TechnikerNr)" +
            "REFERENCES techniker (TechnikerID)," +
            "CONSTRAINT fkArtikelBestellungsdetails FOREIGN KEY (ArtikelNr)" +
            "REFERENCES artikel (ArtikelID)" +
            ")" +
            ";";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();
      
      sql = "CREATE TABLE IF NOT EXISTS lager" +
            "(" +
            "Lagername varchar(70)," +
            "TechnikerNr int(70)," +
            "PRIMARY KEY (Lagername, TechnikerNr)," +
            "Bestand int(11)," +
            "Mindestbestand int(11)," +
            "ArtikelNr int(11)," +
            "CONSTRAINT fkArtikelLager FOREIGN KEY (ArtikelNr)" +
            "REFERENCES artikel (ArtikelID)," +
            "CONSTRAINT fkTechnikerLager FOREIGN KEY (TechnikerNr)" +
            "REFERENCES techniker (TechnikerID)" +
            ")" +
            ";";

      command = new MySqlCommand(sql, connection);
      command.ExecuteNonQuery();
      

      
      connection.Dispose();
    }
  }
}