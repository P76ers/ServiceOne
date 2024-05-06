using System.Windows.Forms;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcLager : UserControl
  {
    public UcLager()
    {
      InitializeComponent();
      DBLager.SelectLager(dataGridView);
    }
  }
}
