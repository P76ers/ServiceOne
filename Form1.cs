using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceOne.Model;
using ServiceOne.Model.Database;

namespace ServiceOne
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      // DBKunde.SelectKunden(dataGridView);
      // DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
      // DBArtikel.SelectArtikel(dataGridView);
      // DBTechniker.SelectTechniker(dataGridView);
      // DBBestellung.SelectBestellung(dataGridView);
      // DBBestelldetails.SelectBestelldetails(dataGridView);
      DBLager.SelectLager(dataGridView);
    }
  }
}