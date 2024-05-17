using System;
using System.Windows.Forms;
using MySqlConnector;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Model
{
  public class DBCrudTest
  {
    #region Kunde

    private static Kunde kunde =
      new Kunde("",
        "Peter",
        "Parker",
        "Parkallee",
        "16",
        "22043",
        "Hamburg",
        "peter@parker.com",
        "040-4227676",
        5.2);

    private static Kunde kunde2 = new Kunde();

    private static Kunde kunde3 =
      new Kunde(1, "",
        "Clark",
        "Kent",
        "Kryptostrasse",
        "22",
        "22049",
        "Hamburg",
        "clark@kent.com",
        "040-987654",
        4.2);

    #endregion

    #region Artikelkategorien

    private static Artikelkategorien artikelkategorien1 = new Artikelkategorien("Ersatzteile", "Ecolab");

    private static Artikelkategorien artikelkategorien2 = new Artikelkategorien();

    private static Artikelkategorien artikelkategorien3 = new Artikelkategorien(1, "Ersatzteile", "Miele");

    #endregion

    #region Artikel

    private static Artikel artikel1 = new Artikel(11428, "Laugenpumpe", "PL19/3F 220V50HZ", 99.00, 1, "11428.jpg");
    private static Artikel artikel2 = new Artikel(11428, "Laugenpumpe", "PL19/3F 220V50HZ", 99.00, 1, "11428.jpg");

    private static Artikel artikel3 =
      new Artikel(1, 11428, "Miele Laugenpumpe", "PL19/3F 220V50HZ", 199.00, 1, "11428.jpg");

    #endregion

    #region Techniker

    private static Techniker techniker = new Techniker("Peter", "Jackson", "HH-XY-2301");
    private static Techniker techniker2 = new Techniker(2, "Peter", "Jackson", "HH-XY-2301");
    private static Techniker techniker3 = new Techniker(1, "", "", "");

    #endregion

    #region Bestellung

    private static DateTime dateTime = new DateTime(2024, 05, 03);
    private static DateTime dateTime2 = new DateTime(2022, 06, 11);
    private static Bestellung bestellung = new Bestellung(1, dateTime);
    private static Bestellung bestellung2 = new Bestellung(2, 1, dateTime);
    private static Bestellung bestellung3 = new Bestellung(1, 1, dateTime2);

    #endregion

    #region Bestelldetails

    private static Bestelldetails bestelldetails = new Bestelldetails(1, 1, 1, 5);
    private static Bestelldetails bestelldetails2 = new Bestelldetails(3, 1, 1, 4);
    private static Bestelldetails bestelldetails3 = new Bestelldetails(1, 1, 1, 55);

    #endregion

    #region Lager

    private static Lager lager = new Lager(1, 3, 5, 1);
    private static Lager lager2 = new Lager(1, 4, 6, 2);
    private static Lager lager3 = new Lager(1, 3, 6, 6);

    #endregion

    public static void Run()
    {
      #region Kunde

      // Create
      // DBKunde.InsertIntoKunden(kunde);
      // DBKunde.InsertIntoKunden(kunde);

      // Delete
      // kunde2.KundenId = 2;
      // DBKunde.DeleteKunden(kunde2);

      // Update
      // DBKunde.UpdateKunden(kunde3);

      #endregion

      #region Artikelkategorien

      // Create
      // DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorien1);
      // DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorien1);

      // Delete
      // artikelkategorien2.KategorieId = 2;
      // DBArtikelkategorien.DeleteArtikelkategorien(artikelkategorien2);

      // Update
      // DBArtikelkategorien.UpdateArtikelkategorien(artikelkategorien3);

      #endregion

      #region Artikel

      // Create
      // DBArtikel.InsertIntoArtikel(artikel1);
      // DBArtikel.InsertIntoArtikel(artikel2);

      // Delete
      // artikel2.ArtikelId = 2;
      // DBArtikel.DeleteArtikel(artikel2);

      // Update
      // DBArtikel.UpdateArtikel(artikel3);

      #endregion

      #region Techniker

      // Create
      // DBTechniker.InsertIntoTechniker(techniker);
      // DBTechniker.InsertIntoTechniker(techniker2);

      // Delete
      // DBTechniker.DeleteTechniker(techniker2);

      // Update
      // DBTechniker.UpdateTechniker(techniker3);

      #endregion

      #region Bestellung

      // Create
      // DBBestellung.InsertIntoBestellung(bestellung);
      // DBBestellung.InsertIntoBestellung(bestellung);

      // Delete
      // DBBestellung.DeleteBestellung(bestellung2);

      // Update
      // DBBestellung.UpdateBestellung(bestellung3);

      #endregion

      #region Bestelldetails

      // Create
      // DBBestelldetails.InsertIntoBestelldetails(bestelldetails);
      // DBBestelldetails.InsertIntoBestelldetails(bestelldetails2);

      // Delete
      // DBBestelldetails.DeleteBestelldetails(bestelldetails2);

      // Update
      // DBBestelldetails.UpdateBestelldetails(bestelldetails3);

      #endregion

      #region Lager

      // Create
      // DBLager.InsertIntoLager(lager);
      // DBLager.InsertIntoLager(lager2);

      // Delete
      // DBLager.DeleteLager(lager2);

      // Update
      // DBLager.UpdateLager(lager3);

      #endregion
    }
  }
}