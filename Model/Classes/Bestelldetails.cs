namespace ServiceOne.Model.Classes
{
  public class Bestelldetails
  {
    private int bestellNr;
    private int technikerNr;
    private int artikelNr;
    private double anzahl;
    
    public Bestelldetails(){}

    public Bestelldetails(int bestellNr, int technikerNr, int artikelNr, double anzahl)
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

    public double Anzahl
    {
      get => anzahl;
      set => anzahl = value;
    }

    #endregion
  }
}