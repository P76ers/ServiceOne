namespace ServiceOne.Model.Classes
{
  public class Artikel
  {
    private int artikelId;
    private int materialNr;
    private string artikelname;
    private string beschreibung;
    private double einzelpreis;
    private int kategorieNr;
    private string bild;
    
    public Artikel(){}

    public Artikel(int artikelId, int materialNr, string artikelname,
      string beschreibung, double einzelpreis, int kategorieNr, string bild)
    {
      this.artikelId = artikelId;
      this.materialNr = materialNr;
      this.artikelname = artikelname;
      this.beschreibung = beschreibung;
      this.einzelpreis = einzelpreis;
      this.kategorieNr = kategorieNr;
      this.bild = bild;
    }

    public Artikel(int materialNr, string artikelname,
      string beschreibung, double einzelpreis, int kategorieNr, string bild)
    {
      this.materialNr = materialNr;
      this.artikelname = artikelname;
      this.beschreibung = beschreibung;
      this.einzelpreis = einzelpreis;
      this.kategorieNr = kategorieNr;
      this.bild = bild;
    }

    #region Properties

    public int ArtikelId
    {
      get => artikelId;
      set => artikelId = value;
    }

    public int MaterialNr
    {
      get => materialNr;
      set => materialNr = value;
    }

    public string Artikelname
    {
      get => artikelname;
      set => artikelname = value;
    }

    public string Beschreibung
    {
      get => beschreibung;
      set => beschreibung = value;
    }

    public double Einzelpreis
    {
      get => einzelpreis;
      set => einzelpreis = value;
    }

    public int KategorieNr
    {
      get => kategorieNr;
      set => kategorieNr = value;
    }

    public string Bild
    {
      get => bild;
      set => bild = value;
    }

    #endregion
  }
}