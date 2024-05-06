using System.Windows.Forms;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcBestellungen : UserControl
  {
    public UcBestellungen()
    {
      InitializeComponent();
      DBBestellung.SelectBestellung(dataGridView);
    }
  }
}
