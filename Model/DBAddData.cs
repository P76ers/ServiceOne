using System;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Model
{
  public class DBAddData
  {
    public static Kunde kunde1 =
      new Kunde("Alfreds Futterkiste", "Maria", "Anders",
        "Obere Straße", "57B", "12209", "Berlin", "maria@fiktiv.net",
        "030-0074321", 1.2);

    public static Kunde kunde2 =
      new Kunde("B's Beverages", "Victoria", "Ashworth",
        "Fauntleroy Circus", "21", "EC2 5NT", "London", "victoria@fiktiv.net",
        "(71) 555-1212", 1.3);

    public static Kunde kunde3 =
      new Kunde("Ricardo Adocicados", "Janete", "Limeira",
        "Av. Copacabana", "267", "02389-890", "Rio de Janeiro", "janete@fiktiv.net",
        "(21) 555-3412", 1.7);

    public static Artikelkategorien artikelkategorie1 =
      new Artikelkategorien("Ersatzteile", "Miele");

    public static Artikelkategorien artikelkategorie2 =
      new Artikelkategorien("Dienstleistungen", "");


    public static Artikelkategorien artikelkategorie3 =
      new Artikelkategorien("Gerätschaften", "Miele");

    public static Artikel artikel1 =
      new Artikel(11428, "Laugenpumpe", "PL19/3F 220V50HZ",
        99.0, 1, "11428.png");

    public static Artikel artikel2 =
      new Artikel(1234, "Anfahrt", "3,0KW 220V",
        49.0, 2, "");

    public static Artikel artikel3 =
      new Artikel(1234, "WDA 111", "Waschmaschine",
        599.0, 3, "wda111.png");

    public static Techniker techniker1 =
      new Techniker("Hauptlager", "HH", "");

    public static Techniker techniker2 =
      new Techniker("Jesse", "Pinkman", "PI-NK-2234");

    public static Techniker techniker3 =
      new Techniker("Walther", "Heisenberg", "HH-WH-1306");

    public static Lager lager1 = new Lager(1, 1, 7, 5);
    public static Lager lager2 = new Lager(1, 3, 1, 2);
    public static Lager lager3 = new Lager(2, 1, 1, 2);
    public static Lager lager4 = new Lager(3, 1, 3, 2);

    private static DateTime date1 = new DateTime(2023, 11, 14);
    private static DateTime date2 = new DateTime(2024, 01, 09);
    private static DateTime date3 = new DateTime(2024, 04, 23);

    public static Bestellung bestellung1 = new Bestellung(1, date1);
    public static Bestellung bestellung2 = new Bestellung(2, date2);
    public static Bestellung bestellung3 = new Bestellung(3, date3);

    private static Bestelldetails bestelldetails1 = new Bestelldetails(1, 1, 2, 1.5);
    private static Bestelldetails bestelldetails2 = new Bestelldetails(1, 1, 1, 1);
    private static Bestelldetails bestelldetails3 = new Bestelldetails(2, 3, 2, 2.0);
    private static Bestelldetails bestelldetails4 = new Bestelldetails(2, 3, 3, 1);


    public static void InsertValues()
    {
      DBKunde.InsertIntoKunden(kunde1);
      DBKunde.InsertIntoKunden(kunde2);
      DBKunde.InsertIntoKunden(kunde3);

      DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorie1);
      DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorie2);
      DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorie3);

      DBArtikel.InsertIntoArtikel(artikel1);
      DBArtikel.InsertIntoArtikel(artikel2);
      DBArtikel.InsertIntoArtikel(artikel3);

      DBTechniker.InsertIntoTechniker(techniker1);
      DBTechniker.InsertIntoTechniker(techniker2);
      DBTechniker.InsertIntoTechniker(techniker3);

      DBLager.InsertIntoLager(lager1);
      DBLager.InsertIntoLager(lager2);
      DBLager.InsertIntoLager(lager3);
      DBLager.InsertIntoLager(lager4);

      DBBestellung.InsertIntoBestellung(bestellung1);
      DBBestellung.InsertIntoBestellung(bestellung2);
      DBBestellung.InsertIntoBestellung(bestellung3);

      DBBestelldetails.InsertIntoBestelldetails(bestelldetails1);
      DBBestelldetails.InsertIntoBestelldetails(bestelldetails2);
      DBBestelldetails.InsertIntoBestelldetails(bestelldetails3);
      DBBestelldetails.InsertIntoBestelldetails(bestelldetails4);
    }
  }
}