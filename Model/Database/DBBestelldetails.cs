using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ServiceOne.Model.Classes;

namespace ServiceOne.Model.Database
{
  public class DBBestelldetails :DBModel
  {
    public static void SelectBestelldetails(DataGridView dataGridView)
    {
      try
      {
        ConnectDatabase();
        
        sql = "SELECT * FROM bestelldetails;";
        command = new MySqlCommand(sql, connection);
        
        adapter = new MySqlDataAdapter(command);
        dataset = new DataSet();
        adapter.Fill(dataset);

        dataGridView.DataSource = dataset.Tables[0];
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      finally
      {
        connection.Close();
      }
    }
    
    public static void InsertIntoBestelldetails(Bestelldetails bestelldetails)
    {
      try
      {
        ConnectDatabase();

        sql =
          "INSERT INTO bestelldetails(BestellNr, TechnikerNr, ArtikelNr, Anzahl) " +
          "VALUES (@bestellNr, @technikerNr, @artikelNr, @anzahl);";


        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("BestellNr", bestelldetails.BestellNr);
        command.Parameters.AddWithValue("TechnikerNr", bestelldetails.TechnikerNr);
        command.Parameters.AddWithValue("ArtikelNr", bestelldetails.ArtikelNr);
        command.Parameters.AddWithValue("Anzahl", bestelldetails.Anzahl);



        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show("Erfolg!");
        }
        else
        {
          MessageBox.Show("Fehler!");
        }
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      finally
      {
        connection.Dispose();
      }
    }
    
    public static void DeleteBestelldetails(Bestelldetails bestelldetails)
    {
      ConnectDatabase();

      try
      {
        sql = "DELETE FROM bestelldetails WHERE BestellNr = " + bestelldetails.BestellNr + 
              " AND TechnikerNr = " + bestelldetails.TechnikerNr + ";";

        command = new MySqlCommand(sql, connection);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"BestellNr / TechnikerNr {bestelldetails.BestellNr} / {bestelldetails.TechnikerNr} Gelöscht");
        }
        else
        {
          MessageBox.Show("Fehler!");
        }
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      finally
      {
        connection.Dispose();
      }
    }

    public static void UpdateBestelldetails(Bestelldetails bestelldetails)
    {
      ConnectDatabase();

      try
      {
        sql = "UPDATE bestelldetails " +
              "SET ArtikelNr=@artikelNr,Anzahl=@anzahl " +
              "WHERE BestellNr = " + bestelldetails.BestellNr + 
              " AND TechnikerNr = " + bestelldetails.TechnikerNr + ";";
      
        command = new MySqlCommand(sql, connection);
      
        command.Parameters.AddWithValue("ArtikelNr", bestelldetails.ArtikelNr);
        command.Parameters.AddWithValue("Anzahl", bestelldetails.Anzahl);


        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"BestellNr / TechnikerNr {bestelldetails.BestellNr} / {bestelldetails.TechnikerNr} aktualisiert");

        }
        else
        {
          MessageBox.Show("Fehler!");
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
      finally
      {
        connection.Dispose();
      }
      
    }


  }
}