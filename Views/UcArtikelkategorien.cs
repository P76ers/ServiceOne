using System;
using System.Windows.Forms;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcArtikelkategorien : UserControl
  {
    public UcArtikelkategorien()
    {
      InitializeComponent();
      DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
    }

    void ResetTextboxes()
    {
      txtBoxKategorieID.Text = "";
      txtBoxKategoriename.Text = "";
      txtBoxRichBeschreibung.Text = "";
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      ResetTextboxes();
    }

    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxKategorieID.Text = dataGridView.CurrentRow.Cells["KategorieID"].Value.ToString();
      txtBoxKategoriename.Text = dataGridView.CurrentRow.Cells["Kategoriename"].Value.ToString();
      txtBoxRichBeschreibung.Text = dataGridView.CurrentRow.Cells["Beschreibung"].Value.ToString();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      Artikelkategorien artikelkategorien = new Artikelkategorien();

      artikelkategorien.Kategoriename = txtBoxKategoriename.Text;
      artikelkategorien.Beschreibung = txtBoxRichBeschreibung.Text;

      DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorien);
      DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
      ResetTextboxes();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Artikelkategorien artikelkategorien = new Artikelkategorien();

      artikelkategorien.KategorieId = Convert.ToInt32(txtBoxKategorieID.Text);
      artikelkategorien.Kategoriename = txtBoxKategoriename.Text;
      artikelkategorien.Beschreibung = txtBoxRichBeschreibung.Text;

      DBArtikelkategorien.UpdateArtikelkategorien(artikelkategorien);
      DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
      ResetTextboxes();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Artikelkategorien artikelkategorien = new Artikelkategorien();

      artikelkategorien.KategorieId = Convert.ToInt32(txtBoxKategorieID.Text);

      DBArtikelkategorien.DeleteArtikelkategorien(artikelkategorien);
      DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
      ResetTextboxes();
    }
  }
}