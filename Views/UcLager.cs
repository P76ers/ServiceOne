using System;
using System.Windows.Forms;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcLager : UserControl
  {
    public UcLager()
    {
      InitializeComponent();
      DBLager.SelectLager(dataGridView);
    }

    void ResetTextboxes()
    {
      txtBoxLagername.Text = "";
      txtBoxLagerNr.Text = "";
      txtBoxBestand.Text = "";
      txtBoxMindestbestand.Text = "";
      txtBoxArtikelNr.Text = "";
    }

    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxLagername.Text = dataGridView.CurrentRow.Cells["Lagername"].Value.ToString();
      txtBoxLagerNr.Text = dataGridView.CurrentRow.Cells["LagerNr"].Value.ToString();
      txtBoxArtikelNr.Text = dataGridView.CurrentRow.Cells["ArtikelNr"].Value.ToString();
      txtBoxBestand.Text = dataGridView.CurrentRow.Cells["Bestand"].Value.ToString();
      txtBoxMindestbestand.Text = dataGridView.CurrentRow.Cells["Mindestbestand"].Value.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      ResetTextboxes();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      Lager lager = new Lager();

      lager.LagerNr = Convert.ToInt32(txtBoxLagerNr.Text);
      lager.ArtikelNr = Convert.ToInt32(txtBoxArtikelNr.Text);
      lager.Bestand = Convert.ToInt32(txtBoxBestand.Text);
      lager.MindestBestand = Convert.ToInt32(txtBoxMindestbestand.Text);

      DBLager.InsertIntoLager(lager);
      DBLager.SelectLager(dataGridView);
      ResetTextboxes();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Lager lager = new Lager();

      lager.LagerNr = Convert.ToInt32(txtBoxLagerNr.Text);
      lager.ArtikelNr = Convert.ToInt32(txtBoxArtikelNr.Text);
      lager.Bestand = Convert.ToInt32(txtBoxBestand.Text);
      lager.MindestBestand = Convert.ToInt32(txtBoxMindestbestand.Text);

      DBLager.UpdateLager(lager);
      DBLager.SelectLager(dataGridView);
      ResetTextboxes();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Lager lager = new Lager();

      lager.LagerNr = Convert.ToInt32(txtBoxLagerNr.Text);
      lager.ArtikelNr = Convert.ToInt32(txtBoxArtikelNr.Text);

      DBLager.DeleteLager(lager);
      DBLager.SelectLager(dataGridView);
      ResetTextboxes();
    }
  }
}