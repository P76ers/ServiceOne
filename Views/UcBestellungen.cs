using System;
using System.Windows.Forms;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcBestellungen : UserControl
  {
    public UcBestellungen()
    {
      InitializeComponent();
      DBBestellung.SelectBestellung(dataGridView);
    }

    void ResetTextboxes()
    {
      txtBoxBestellID.Text = "";
      txtBoxKundenNr.Text = "";
      dtpDatum.Value = DateTime.Now;
    }

    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxBestellID.Text = dataGridView.CurrentRow.Cells["BestellID"].Value.ToString();
      txtBoxKundenNr.Text = dataGridView.CurrentRow.Cells["KundenNr"].Value.ToString();
      dtpDatum.Text = dataGridView.CurrentRow.Cells["Datum"].Value.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      ResetTextboxes();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      Bestellung bestellung = new Bestellung();

      bestellung.KundenNr = Convert.ToInt32(txtBoxKundenNr.Text);
      bestellung.Datum = dtpDatum.Value;

      DBBestellung.InsertIntoBestellung(bestellung);
      DBBestellung.SelectBestellung(dataGridView);
      ResetTextboxes();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Bestellung bestellung = new Bestellung();

      bestellung.BestellId = Convert.ToInt32(txtBoxBestellID.Text);
      bestellung.KundenNr = Convert.ToInt32(txtBoxKundenNr.Text);
      bestellung.Datum = dtpDatum.Value;

      DBBestellung.UpdateBestellung(bestellung);
      DBBestellung.SelectBestellung(dataGridView);
      ResetTextboxes();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Bestellung bestellung = new Bestellung();

      bestellung.BestellId = Convert.ToInt32(txtBoxBestellID.Text);

      DBBestellung.DeleteBestellung(bestellung);
      DBBestellung.SelectBestellung(dataGridView);
      ResetTextboxes();
    }
  }
}