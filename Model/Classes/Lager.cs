namespace ServiceOne.Model.Classes
{
  public class Lager
  {
    private int lagerId;
    private string lagerName;
    private int technikerNr;
    private int bestand;
    private int mindestBestand;
    private int artikelNr;
    
    public Lager(){}

    public Lager(int lagerId, string lagerName, int technikerNr, int bestand, int mindestBestand, int artikelNr)
    {
      this.lagerId = lagerId;
      this.lagerName = lagerName;
      this.technikerNr = technikerNr;
      this.bestand = bestand;
      this.mindestBestand = mindestBestand;
      this.artikelNr = artikelNr;
    }

    public Lager(string lagerName, int technikerNr, int bestand, int mindestBestand, int artikelNr)
    {
      this.lagerName = lagerName;
      this.technikerNr = technikerNr;
      this.bestand = bestand;
      this.mindestBestand = mindestBestand;
      this.artikelNr = artikelNr;
    }

    #region Properties

    public int LagerId
    {
      get => lagerId;
      set => lagerId = value;
    }

    public string LagerName
    {
      get => lagerName;
      set => lagerName = value;
    }

    public int TechnikerNr
    {
      get => technikerNr;
      set => technikerNr = value;
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

    public int ArtikelNr
    {
      get => artikelNr;
      set => artikelNr = value;
    }

    #endregion
  }
}