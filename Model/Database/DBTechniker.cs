using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ServiceOne.Model.Classes;

namespace ServiceOne.Model.Database
{
  public class DBTechniker : DBModel
  {
    public static void SelectTechniker(DataGridView dataGridView)
    {
      try
      {
        ConnectDatabase();

        sql = "SELECT * FROM techniker;";
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

    public static void InsertIntoTechniker(Techniker techniker)
    {
      try
      {
        ConnectDatabase();

        sql =
          "INSERT INTO techniker(Vorname, Nachname, KFZ) " +
          "VALUES (@vorname, @nachname, @kfz);";


        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("Vorname", techniker.Vorname);
        command.Parameters.AddWithValue("Nachname", techniker.Nachname);
        command.Parameters.AddWithValue("Kfz", techniker.Kfz);


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

    public static void DeleteTechniker(Techniker techniker)
    {
      ConnectDatabase();

      try
      {
        sql = "DELETE FROM techniker WHERE TechnikerID = " + techniker.TechnikerId + ";";

        command = new MySqlCommand(sql, connection);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"ID: {techniker.TechnikerId} Gelöscht");
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

    public static void UpdateTechniker(Techniker techniker)
    {
      ConnectDatabase();

      try
      {
        sql = "UPDATE techniker " +
              "SET Vorname=@vorname,Nachname=@nachname,KFZ=@kfz " +
              "WHERE TechnikerID= " + techniker.TechnikerId + ";";

        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("Vorname", techniker.Vorname);
        command.Parameters.AddWithValue("Nachname", techniker.Nachname);
        command.Parameters.AddWithValue("Kfz", techniker.Kfz);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"ID:{techniker.TechnikerId} aktualisiert!");
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