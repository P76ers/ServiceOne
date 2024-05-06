using System.Windows.Forms;
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
  }
}
