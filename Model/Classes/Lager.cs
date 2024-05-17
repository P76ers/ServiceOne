namespace ServiceOne.Model.Classes
{
  public class Lager
  {
    private int lagerNr;
    private int artikelNr;
    private int bestand;
    private int mindestBestand;

    public Lager()
    {
    }

    public Lager(int lagerNr, int artikelNr, int bestand, int mindestBestand)
    {
      this.lagerNr = lagerNr;
      this.artikelNr = artikelNr;
      this.bestand = bestand;
      this.mindestBestand = mindestBestand;
    }

    public Lager(int artikelNr, int bestand, int mindestBestand)
    {
      this.artikelNr = artikelNr;
      this.bestand = bestand;
      this.mindestBestand = mindestBestand;
    }

    #region Properties

    public int LagerNr
    {
      get => lagerNr;
      set => lagerNr = value;
    }

    public int ArtikelNr
    {
      get => artikelNr;
      set => artikelNr = value;
    }

    public int Bestand
    {
      get => bestand;
      set => bestand = value;
    }

    public int MindestBestand
    {
      get => mindestBestand;
      set => mindestBestand = value;
    }

    #endregion
  }
}