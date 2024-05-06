using System;
using System.Windows.Forms;


namespace ServiceOne.Views
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
      UcHome ucHome = new UcHome();
      addUserControl(ucHome);
    }

    #region Menu: MouseMove | MouseLeave

    private void btnHome_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Home";
    }

    private void btnHome_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnArtikel_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Artikel";
    }

    private void btnArtikel_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnArtikelkategorien_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Artikelkategorien";
    }

    private void btnArtikelkategorien_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnLager_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Lager";
    }

    private void btnLager_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnTechniker_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Techniker";
    }

    private void btnTechniker_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnKunden_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Kunden";
    }

    private void btnKunden_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnBestellungen_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Bestellungen";
    }

    private void btnBestellungen_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnBestelldetails_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "Bestelldetails";
    }

    private void btnBestelldetails_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    private void btnWarenkorb_MouseMove(object sender, MouseEventArgs e)
    {
      lblMenu.Text = "neue Bestellung";
    }

    private void btnWarenkorb_MouseLeave(object sender, EventArgs e)
    {
      lblMenu.Text = "";
    }

    #endregion

    private void addUserControl(UserControl userControl)
    {
      userControl.Dock = DockStyle.Fill;
      panelMain.Controls.Clear();
      panelMain.Controls.Add(userControl);
      userControl.BringToFront();
    }

    #region Menu OnClick

    private void btnHome_Click(object sender, EventArgs e)
    {
      UcHome ucHome = new UcHome();
      addUserControl(ucHome);
    }

    private void btnArtikel_Click(object sender, EventArgs e)
    {
      UcArtikel ucArtikel = new UcArtikel();
      addUserControl(ucArtikel);
    }

    private void btnKunden_Click(object sender, EventArgs e)
    {
      UcKunden ucKunden = new UcKunden();
      addUserControl(ucKunden);
    }

    private void btnWarenkorb_Click(object sender, EventArgs e)
    {
      UcNeueBestellung ucNeueBestellung = new UcNeueBestellung();
      addUserControl(ucNeueBestellung);
    }


    private void btnArtikelkategorien_Click(object sender, EventArgs e)
    {
      UcArtikelkategorien ucArtikelkategorien = new UcArtikelkategorien();
      addUserControl(ucArtikelkategorien);
    }

    private void btnLager_Click(object sender, EventArgs e)
    {
      UcLager ucLager = new UcLager();
      addUserControl(ucLager);
    }

    private void btnTechniker_Click(object sender, EventArgs e)
    {
      UcTechniker ucTechniker = new UcTechniker();
      addUserControl(ucTechniker);
    }

    private void btnBestellungen_Click(object sender, EventArgs e)
    {
      UcBestellungen ucBestellungen = new UcBestellungen();
      addUserControl(ucBestellungen);
    }

    private void btnBestelldetails_Click(object sender, EventArgs e)
    {
      UcBestelldetails ucBestellungdetails = new UcBestelldetails();
      addUserControl(ucBestellungdetails);
    }

    #endregion
  }
}