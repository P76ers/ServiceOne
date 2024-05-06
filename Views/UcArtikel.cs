using System.Windows.Forms;
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
  }
}
