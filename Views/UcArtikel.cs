using System;
using System.Windows.Forms;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcArtikel : UserControl
  {
    public UcArtikel()
    {
      InitializeComponent();
      DBArtikel.SelectArtikel(dataGridView);
    }

    void ResetTextboxes()
    {
      txtBoxArtikelID.Text = "";
      txtBoxMaterialNr.Text = "";
      txtBoxArtikelname.Text = "";
      txtBoxRichBeschreibung.Text = "";
      txtBoxEinzelpreis.Text = "";
      txtBoxKategorieNr.Text = "";
      txtBoxBild.Text = "";
    }

    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxArtikelID.Text = dataGridView.CurrentRow.Cells["ArtikelID"].Value.ToString();
      txtBoxMaterialNr.Text = dataGridView.CurrentRow.Cells["MaterialNr"].Value.ToString();
      txtBoxArtikelname.Text = dataGridView.CurrentRow.Cells["Artikelname"].Value.ToString();
      txtBoxRichBeschreibung.Text = dataGridView.CurrentRow.Cells["Beschreibung"].Value.ToString();
      txtBoxEinzelpreis.Text = dataGridView.CurrentRow.Cells["Einzelpreis"].Value.ToString();
      txtBoxKategorieNr.Text = dataGridView.CurrentRow.Cells["KategorieNr"].Value.ToString();
      txtBoxBild.Text = dataGridView.CurrentRow.Cells["Bild"].Value.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      ResetTextboxes();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      Artikel artikel = new Artikel();

      artikel.MaterialNr = Convert.ToInt32(txtBoxMaterialNr.Text);
      artikel.Artikelname = txtBoxArtikelname.Text;
      artikel.Beschreibung = txtBoxRichBeschreibung.Text;
      artikel.Einzelpreis = Convert.ToDouble(txtBoxEinzelpreis.Text);
      artikel.KategorieNr = Convert.ToInt32(txtBoxKategorieNr.Text);
      artikel.Bild = txtBoxBild.Text;

      DBArtikel.InsertIntoArtikel(artikel);
      DBArtikel.SelectArtikel(dataGridView);
      ResetTextboxes();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Artikel artikel = new Artikel();

      artikel.ArtikelId = Convert.ToInt32(txtBoxArtikelID.Text);
      artikel.MaterialNr = Convert.ToInt32(txtBoxMaterialNr.Text);
      artikel.Artikelname = txtBoxArtikelname.Text;
      artikel.Beschreibung = txtBoxRichBeschreibung.Text;
      artikel.Einzelpreis = Convert.ToDouble(txtBoxEinzelpreis.Text);
      artikel.KategorieNr = Convert.ToInt32(txtBoxKategorieNr.Text);
      artikel.Bild = txtBoxBild.Text;

      DBArtikel.UpdateArtikel(artikel);
      DBArtikel.SelectArtikel(dataGridView);
      ResetTextboxes();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Artikel artikel = new Artikel();

      artikel.ArtikelId = Convert.ToInt32(txtBoxArtikelID.Text);

      DBArtikel.DeleteArtikel(artikel);
      DBArtikel.SelectArtikel(dataGridView);
      ResetTextboxes();
    }
  }
}