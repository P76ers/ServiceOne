using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ServiceOne.Model.Classes;

namespace ServiceOne.Model.Database
{
  public class DBArtikel : DBModel
  {
    public static void SelectArtikel(DataGridView dataGridView)
    {
      try
      {
        ConnectDatabase();
        
        sql = "SELECT * FROM artikel;";
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
    
    public static void InsertIntoArtikel(Artikel artikel)
    {
      try
      {
        ConnectDatabase();

        sql =
          "INSERT INTO artikel(MaterialNr, Artikelname, Beschreibung, Einzelpreis, KategorieNr, Bild) " +
          "VALUES (@materialNr, @artikelname, @beschreibung, @einzelpreis, @kategorieNr, @bild);";
        
        command = new MySqlCommand(sql, connection);

        command.Parameters.AddWithValue("MaterialNr", artikel.MaterialNr);
        command.Parameters.AddWithValue("Artikelname", artikel.Artikelname);
        command.Parameters.AddWithValue("Beschreibung", artikel.Beschreibung);
        command.Parameters.AddWithValue("Einzelpreis", artikel.Einzelpreis);
        command.Parameters.AddWithValue("KategorieNr", artikel.KategorieNr);
        command.Parameters.AddWithValue("Bild", artikel.Bild);
        
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
    
    public static void DeleteArtikel(Artikel artikel)
    {
      ConnectDatabase();

      try
      {
        sql = "DELETE FROM artikel WHERE ArtikelID = " + artikel.ArtikelId + ";";

        command = new MySqlCommand(sql, connection);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"ID: {artikel.ArtikelId} Gelöscht");
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
    
    public static void UpdateArtikel(Artikel artikel)
    {
      ConnectDatabase();

      try
      {
        sql = "UPDATE artikel " +
              "SET MaterialNr=@materialNr,Artikelname=@artikelname,Beschreibung=@beschreibung,Einzelpreis=@einzelpreis,KategorieNr=@kategorieNr, Bild=@bild " +
              "WHERE ArtikelID= " + artikel.ArtikelId + ";";
      
        command = new MySqlCommand(sql, connection);
      
        command.Parameters.AddWithValue("MaterialNr", artikel.MaterialNr);
        command.Parameters.AddWithValue("Artikelname", artikel.Artikelname);
        command.Parameters.AddWithValue("Beschreibung", artikel.Beschreibung);
        command.Parameters.AddWithValue("Einzelpreis", artikel.Einzelpreis);
        command.Parameters.AddWithValue("KategorieNr", artikel.KategorieNr);
        command.Parameters.AddWithValue("Bild", artikel.Bild);


        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
          MessageBox.Show($"ID:{ artikel.ArtikelId} aktualisiert!");
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