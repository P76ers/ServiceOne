using System;
using System.Windows.Forms;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcKunden : UserControl
  {
    public UcKunden()
    {
      InitializeComponent();
      DBKunde.SelectKunden(dataGridView);
    }

    void ResetTextboxes()
    {
      txtBoxKundenID.Text = "";
      txtBoxFirma.Text = "";
      txtBoxVorname.Text = "";
      txtBoxNachname.Text = "";
      txtBoxStrasse.Text = "";
      txtBoxHausnummer.Text = "";
      txtBoxPostleitzahl.Text = "";
      txtBoxOrt.Text = "";
      txtBoxEmail.Text = "";
      txtBoxTelefon.Text = "";
      txtBoxRabatt.Text = "";
    }

    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxKundenID.Text = dataGridView.CurrentRow.Cells["KundenID"].Value.ToString();
      txtBoxFirma.Text = dataGridView.CurrentRow.Cells["Firma"].Value.ToString();
      txtBoxVorname.Text = dataGridView.CurrentRow.Cells["Vorname"].Value.ToString();
      txtBoxNachname.Text = dataGridView.CurrentRow.Cells["Nachname"].Value.ToString();
      txtBoxStrasse.Text = dataGridView.CurrentRow.Cells["Strasse"].Value.ToString();
      txtBoxHausnummer.Text = dataGridView.CurrentRow.Cells["Hausnummer"].Value.ToString();
      txtBoxPostleitzahl.Text = dataGridView.CurrentRow.Cells["PLZ"].Value.ToString();
      txtBoxOrt.Text = dataGridView.CurrentRow.Cells["Ort"].Value.ToString();
      txtBoxEmail.Text = dataGridView.CurrentRow.Cells["Email"].Value.ToString();
      txtBoxTelefon.Text = dataGridView.CurrentRow.Cells["Telefon"].Value.ToString();
      txtBoxRabatt.Text = dataGridView.CurrentRow.Cells["Rabatt"].Value.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      ResetTextboxes();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      Kunde kunde = new Kunde();

      kunde.Firma = txtBoxFirma.Text;
      kunde.Vorname = txtBoxVorname.Text;
      kunde.Nachname = txtBoxNachname.Text;
      kunde.Strasse = txtBoxStrasse.Text;
      kunde.Hausnummer = txtBoxHausnummer.Text;
      kunde.Plz = txtBoxPostleitzahl.Text;
      kunde.Ort = txtBoxOrt.Text;
      kunde.Email = txtBoxEmail.Text;
      kunde.Telefon = txtBoxTelefon.Text;
      kunde.Rabatt = Convert.ToDouble(txtBoxRabatt.Text);

      DBKunde.InsertIntoKunden(kunde);
      DBKunde.SelectKunden(dataGridView);
      ResetTextboxes();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Kunde kunde = new Kunde();

      kunde.KundenId = Convert.ToInt32(txtBoxKundenID.Text);


      DBKunde.DeleteKunden(kunde);
      DBKunde.SelectKunden(dataGridView);
      ResetTextboxes();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Kunde kunde = new Kunde();

      kunde.KundenId = Convert.ToInt32(txtBoxKundenID.Text);
      kunde.Firma = txtBoxFirma.Text;
      kunde.Vorname = txtBoxVorname.Text;
      kunde.Nachname = txtBoxNachname.Text;
      kunde.Strasse = txtBoxStrasse.Text;
      kunde.Hausnummer = txtBoxHausnummer.Text;
      kunde.Plz = txtBoxPostleitzahl.Text;
      kunde.Ort = txtBoxOrt.Text;
      kunde.Email = txtBoxEmail.Text;
      kunde.Telefon = txtBoxTelefon.Text;
      kunde.Rabatt = Convert.ToDouble(txtBoxRabatt.Text);

      DBKunde.UpdateKunden(kunde);
      DBKunde.SelectKunden(dataGridView);
      ResetTextboxes();
    }
  }
}