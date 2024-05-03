using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ServiceOne.Model.Classes;

namespace ServiceOne.Model.Database
{
  public class DBBestellung : DBModel
  {
    public static void SelectBestellung(DataGridView dataGridView)
    {
      try
      {
        ConnectDatabase();

        sql = "SELECT * FROM bestellungen;";
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

    public static void InsertIntoBestellung(Bestellung bestellung)
    {
      try
      {
        ConnectDatabase();

        sql =
          "INSERT INTO bestellungen(KundenNr, Datum) " +
          "VALUES (@kundenNr,@datum);";


        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("KundenNr", bestellung.KundenNr);
        command.Parameters.AddWithValue("Datum", bestellung.Datum);


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
    
    public static void DeleteBestellung(Bestellung bestellung)
    {
      ConnectDatabase();

      try
      {
        sql = "DELETE FROM bestellungen WHERE bestellID = " + bestellung.BestellId + ";";

        command = new MySqlCommand(sql, connection);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"ID: {bestellung.BestellId} Gelöscht");
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
    
    public static void UpdateBestellung(Bestellung bestellung)
    {
      ConnectDatabase();

      try
      {
        sql = "UPDATE bestellungen " +
              "SET KundenNr=@kundenNr,Datum=@datum " +
              "WHERE BestellID= " + bestellung.BestellId + ";";
      
        command = new MySqlCommand(sql, connection);
      
        command.Parameters.AddWithValue("KundenNr", bestellung.KundenNr);
        command.Parameters.AddWithValue("Datum", bestellung.Datum);


        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"ID:{bestellung.BestellId} aktualisiert!");
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