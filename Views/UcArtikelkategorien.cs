using System.Windows.Forms;
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
  }
}
