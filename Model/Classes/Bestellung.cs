using System;

namespace ServiceOne.Model.Classes
{
  public class Bestellung
  {
    private int bestellID;
    private int kundenNr;
    private DateTime datum;
    
    public Bestellung(){}

    public Bestellung(int bestellID, int kundenNr, DateTime datum)
    {
      this.bestellID = bestellID;
      this.kundenNr = kundenNr;
      this.datum = datum;
    }

    public Bestellung(int kundenNr, DateTime datum)
    {
      this.kundenNr = kundenNr;
      this.datum = datum;
    }

    #region Properties

    public int BestellId
    {
      get => bestellID;
      set => bestellID = value;
    }

    public int KundenNr
    {
      get => kundenNr;
      set => kundenNr = value;
    }

    public DateTime Datum
    {
      get => datum;
      set => datum = value;
    }

    #endregion
  }
}