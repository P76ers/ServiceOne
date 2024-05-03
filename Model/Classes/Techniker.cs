namespace ServiceOne.Model.Classes
{
  public class Techniker
  {
    private int technikerID;
    private string vorname;
    private string nachname;
    private string kfz;
    
    public Techniker(){}

    public Techniker(int technikerID, string vorname, string nachname, string kfz)
    {
      this.technikerID = technikerID;
      this.vorname = vorname;
      this.nachname = nachname;
      this.kfz = kfz;
    }

    public Techniker(string vorname, string nachname, string kfz)
    {
      this.vorname = vorname;
      this.nachname = nachname;
      this.kfz = kfz;
    }

    #region Properties

    public int TechnikerId
    {
      get => technikerID;
      set => technikerID = value;
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

    public string Kfz
    {
      get => kfz;
      set => kfz = value;
    }

    #endregion
  }
}