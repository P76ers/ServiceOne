using System.Windows.Forms;
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
  }
}
