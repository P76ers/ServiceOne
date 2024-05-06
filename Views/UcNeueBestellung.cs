using System.Windows.Forms;
using ServiceOne.Model.Database;

namespace ServiceOne.Views
{
  
  
  public partial class UcNeueBestellung : UserControl
  {
    
    public UcNeueBestellung()
    {
      InitializeComponent();
      DBKunde.SelectKunden(dataGridView);

    }
  }
}