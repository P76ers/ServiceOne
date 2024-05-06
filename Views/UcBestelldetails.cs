using System.Windows.Forms;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  public partial class UcBestelldetails : UserControl
  {
    public UcBestelldetails()
    {
      InitializeComponent();
      DBBestelldetails.SelectBestelldetails(dataGridView);
    }
  }
}
