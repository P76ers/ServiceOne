namespace ServiceOne.Model.Classes
{
  public class Artikelkategorien
  {
    private int kategorieID;
    private string kategoriename;
    private string beschreibung;
    
    public Artikelkategorien(){}

    public Artikelkategorien(int kategorieID, string kategoriename, string beschreibung)
    {
      this.kategorieID = kategorieID;
      this.kategoriename = kategoriename;
      this.beschreibung = beschreibung;
    }

    public Artikelkategorien(string kategoriename, string beschreibung)
    {
      this.kategoriename = kategoriename;
      this.beschreibung = beschreibung;
    }

    #region Properties

    public int KategorieId
    {
      get => kategorieID;
      set => kategorieID = value;
    }

    public string Kategoriename
    {
      get => kategoriename;
      set => kategoriename = value;
    }

    public string Beschreibung
    {
      get => beschreibung;
      set => beschreibung = value;
    }

    #endregion
  }
}