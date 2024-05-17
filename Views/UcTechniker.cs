using System;
using System.Windows.Forms;
using ServiceOne.Model.Classes;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcTechniker : UserControl
  {
    public UcTechniker()
    {
      InitializeComponent();
      DBTechniker.SelectTechniker(dataGridView);
    }

    void ResetTextboxes()
    {
      txtBoxTechnikerID.Text = "";
      txtBoxVorname.Text = "";
      txtBoxNachname.Text = "";
      txtBoxKfz.Text = "";
    }

    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxTechnikerID.Text = dataGridView.CurrentRow.Cells["TechnikerID"].Value.ToString();
      txtBoxVorname.Text = dataGridView.CurrentRow.Cells["Vorname"].Value.ToString();
      txtBoxNachname.Text = dataGridView.CurrentRow.Cells["Nachname"].Value.ToString();
      txtBoxKfz.Text = dataGridView.CurrentRow.Cells["Kfz"].Value.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      ResetTextboxes();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      Techniker techniker = new Techniker();

      techniker.Vorname = txtBoxVorname.Text;
      techniker.Nachname = txtBoxNachname.Text;
      techniker.Kfz = txtBoxKfz.Text;

      DBTechniker.InsertIntoTechniker(techniker);
      DBTechniker.SelectTechniker(dataGridView);
      ResetTextboxes();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Techniker techniker = new Techniker();

      techniker.TechnikerId = Convert.ToInt32(txtBoxTechnikerID.Text);
      techniker.Vorname = txtBoxVorname.Text;
      techniker.Nachname = txtBoxNachname.Text;
      techniker.Kfz = txtBoxKfz.Text;

      DBTechniker.UpdateTechniker(techniker);
      DBTechniker.SelectTechniker(dataGridView);
      ResetTextboxes();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      Techniker techniker = new Techniker();

      techniker.TechnikerId = Convert.ToInt32(txtBoxTechnikerID.Text);

      DBTechniker.DeleteTechniker(techniker);
      DBTechniker.SelectTechniker(dataGridView);
      ResetTextboxes();
    }
  }
}