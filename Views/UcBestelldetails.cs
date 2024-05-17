using System;
using System.Windows.Forms;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcBestelldetails : UserControl
  {
    public UcBestelldetails()
    {
      InitializeComponent();
      DBBestelldetails.SelectBestelldetails(dataGridView);
    }

    void ResetTextboxes()
    {
      txtBoxBestellNr.Text = "";
      txtBoxTechnikerNr.Text = "";
      txtBoxArtikelNr.Text = "";
      txtBoxAnzahl.Text = "";
    }

    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxBestellNr.Text = dataGridView.CurrentRow.Cells["BestellNr"].Value.ToString();
      txtBoxTechnikerNr.Text = dataGridView.CurrentRow.Cells["TechnikerNr"].Value.ToString();
      txtBoxArtikelNr.Text = dataGridView.CurrentRow.Cells["ArtikelNr"].Value.ToString();
      txtBoxAnzahl.Text = dataGridView.CurrentRow.Cells["Anzahl"].Value.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      ResetTextboxes();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      Bestelldetails bestelldetails = new Bestelldetails();

      bestelldetails.BestellNr = Convert.ToInt32(txtBoxBestellNr.Text);
      bestelldetails.TechnikerNr = Convert.ToInt32(txtBoxTechnikerNr.Text);
      bestelldetails.ArtikelNr = Convert.ToInt32(txtBoxArtikelNr.Text);
      bestelldetails.Anzahl = Convert.ToDouble(txtBoxAnzahl.Text);

      DBBestelldetails.InsertIntoBestelldetails(bestelldetails);
      DBBestelldetails.SelectBestelldetails(dataGridView);
      ResetTextboxes();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Bestelldetails bestelldetails = new Bestelldetails();

      bestelldetails.BestellNr = Convert.ToInt32(txtBoxBestellNr.Text);
      bestelldetails.TechnikerNr = Convert.ToInt32(txtBoxTechnikerNr.Text);
      bestelldetails.ArtikelNr = Convert.ToInt32(txtBoxArtikelNr.Text);
      bestelldetails.Anzahl = Convert.ToDouble(txtBoxAnzahl.Text);

      DBBestelldetails.UpdateBestelldetails(bestelldetails);
      DBBestelldetails.SelectBestelldetails(dataGridView);
      ResetTextboxes();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Bestelldetails bestelldetails = new Bestelldetails();

      bestelldetails.BestellNr = Convert.ToInt32(txtBoxBestellNr.Text);
      bestelldetails.TechnikerNr = Convert.ToInt32(txtBoxTechnikerNr.Text);

      DBBestelldetails.DeleteBestelldetails(bestelldetails);
      DBBestelldetails.SelectBestelldetails(dataGridView);
      ResetTextboxes();
    }
  }
}