using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ServiceOne.Model.Classes;

namespace ServiceOne.Model.Database
{
  public class DBLager : DBModel
  {
    public static void SelectLager(DataGridView dataGridView)
    {
      try
      {
        ConnectDatabase();
        
        sql = "SELECT * FROM lager;";
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
    
    public static void InsertIntoLager(Lager lager)
    {
      try
      {
        ConnectDatabase();

        sql =
          "INSERT INTO lager(Lagername, TechnikerNr, Bestand, Mindestbestand, ArtikelNr) " +
          "VALUES (@lagername, @technikerNr, @bestand, @mindestbestand, @artikelNr);";


        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("Lagername", lager.LagerName);
        command.Parameters.AddWithValue("TechnikerNr", lager.TechnikerNr);
        command.Parameters.AddWithValue("Bestand", lager.Bestand);
        command.Parameters.AddWithValue("Mindestbestand", lager.MindestBestand);
        command.Parameters.AddWithValue("ArtikelNr", lager.ArtikelNr);


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

    public static void DeleteLager(Lager lager)
    {
      ConnectDatabase();

      try
      {
        sql = "DELETE FROM lager WHERE Lagername = '" + lager.LagerName + 
              "' AND TechnikerNr = " + lager.TechnikerNr + ";";


        command = new MySqlCommand(sql, connection);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"Lager: {lager.LagerName} Gelöscht");
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
    
    public static void UpdateLager(Lager lager)
    {
      ConnectDatabase();

      try
      {
        sql = "UPDATE lager " +
              "SET Lagername=@lagername,TechnikerNr=@technikerNr,Bestand=@bestand,Mindestbestand=@mindestbestand, " +
              "ArtikelNr=@artikelNr WHERE LagerID= " + lager.LagerId + ";";
      
        command = new MySqlCommand(sql, connection);
      
        command.Parameters.AddWithValue("Lagername", lager.LagerName);
        command.Parameters.AddWithValue("TechnikerNr", lager.TechnikerNr);
        command.Parameters.AddWithValue("Bestand", lager.Bestand);
        command.Parameters.AddWithValue("Mindestbestand", lager.MindestBestand);
        command.Parameters.AddWithValue("ArtikelNr", lager.ArtikelNr);


        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"ID:{lager.LagerId} aktualisiert!");
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