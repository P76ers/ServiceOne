namespace ServiceOne.Model.Classes
{
  public class Bestelldetails
  {
    private int bestellNr;
    private int technikerNr;
    private int artikelNr;
    private int anzahl;
    
    public Bestelldetails(){}

    public Bestelldetails(int bestellNr, int technikerNr, int artikelNr, int anzahl)
    {
      this.bestellNr = bestellNr;
      this.technikerNr = technikerNr;
      this.artikelNr = artikelNr;
      this.anzahl = anzahl;
    }

    #region Properties

    public int BestellNr
    {
      get => bestellNr;
      set => bestellNr = value;
    }

    public int TechnikerNr
    {
      get => technikerNr;
      set => technikerNr = value;
    }

    public int ArtikelNr
    {
      get => artikelNr;
      set => artikelNr = value;
    }

    public int Anzahl
    {
      get => anzahl;
      set => anzahl = value;
    }

    #endregion
  }
}