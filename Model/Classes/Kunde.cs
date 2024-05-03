namespace ServiceOne.Model.Classes
{
  public class Kunde
  {
    private int kundenID;
    private string firma;
    private string vorname;
    private string nachname;
    private string strasse;
    private string hausnummer;
    private string plz;
    private string ort;
    private string email;
    private string telefon;
    private double rabatt;

    public Kunde(){}
    
    public Kunde(int kundenID, string firma, string vorname, string nachname,
      string strasse, string hausnummer, string plz, string ort, string email, string telefon, double rabatt)
    {
      this.kundenID = kundenID;
      this.firma = firma;
      this.vorname = vorname;
      this.nachname = nachname;
      this.strasse = strasse;
      this.hausnummer = hausnummer;
      this.plz = plz;
      this.ort = ort;
      this.email = email;
      this.telefon = telefon;
      this.rabatt = rabatt;
    }

    public Kunde(string firma, string vorname, string nachname,
      string strasse, string hausnummer, string plz, string ort, string email, string telefon, double rabatt)
    {
      this.firma = firma;
      this.vorname = vorname;
      this.nachname = nachname;
      this.strasse = strasse;
      this.hausnummer = hausnummer;
      this.plz = plz;
      this.ort = ort;
      this.email = email;
      this.telefon = telefon;
      this.rabatt = rabatt;
    }

    #region Properties

    public int KundenId
    {
      get => kundenID;
      set => kundenID = value;
    }

    public string Firma
    {
      get => firma;
      set => firma = value;
    }

    public string Vorname
    {
      get => vorname;
      set => vorname = value;
    }

    public string Nachname
    {
      get => nachname;
      set => nachname = value;
    }

    public string Strasse
    {
      get => strasse;
      set => strasse = value;
    }

    public string Hausnummer
    {
      get => hausnummer;
      set => hausnummer = value;
    }

    public string Plz
    {
      get => plz;
      set => plz = value;
    }

    public string Ort
    {
      get => ort;
      set => ort = value;
    }

    public string Email
    {
      get => email;
      set => email = value;
    }

    public string Telefon
    {
      get => telefon;
      set => telefon = value;
    }

    public double Rabatt
    {
      get => rabatt;
      set => rabatt = value;
    }

    #endregion
    
    
  }
}