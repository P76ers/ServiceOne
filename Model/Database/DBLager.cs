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

        sql = "SELECT CONCAT (Vorname, ' ', Nachname) AS Lagername, " +
              "LagerNr, ArtikelNr, Bestand, Mindestbestand " +
              "FROM lager INNER JOIN techniker ON LagerNr = TechnikerID;";
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
          "INSERT INTO lager(LagerNr, ArtikelNr, Bestand, Mindestbestand) " +
          "VALUES (@lagerNr, @artikelNr, @bestand, @mindestbestand);";

        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("LagerNr", lager.LagerNr);
        command.Parameters.AddWithValue("ArtikelNr", lager.ArtikelNr);
        command.Parameters.AddWithValue("Bestand", lager.Bestand);
        command.Parameters.AddWithValue("Mindestbestand", lager.MindestBestand);

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
        sql = "DELETE FROM lager WHERE LagerNr = '" + lager.LagerNr +
              "' AND ArtikelNr = " + lager.ArtikelNr + ";";

        command = new MySqlCommand(sql, connection);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show(
            $"LagerNr / ArtikelNr {lager.LagerNr} / {lager.ArtikelNr} gelöscht");
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
              "SET LagerNr=@lagerNr,ArtikelNr=@artikelNr,Bestand=@bestand,Mindestbestand=@mindestbestand " +
              "WHERE LagerNr= " + lager.LagerNr + " " +
              "AND ArtikelNr= " + lager.ArtikelNr +
              ";";

        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("LagerNr", lager.LagerNr);
        command.Parameters.AddWithValue("ArtikelNr", lager.ArtikelNr);
        command.Parameters.AddWithValue("Bestand", lager.Bestand);
        command.Parameters.AddWithValue("Mindestbestand", lager.MindestBestand);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"LagerNr / ArtikelNr {lager.LagerNr} / {lager.ArtikelNr} aktualisiert!");
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