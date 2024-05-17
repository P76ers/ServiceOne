using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceOne.Model;
using ServiceOne.Model.Database;
using ServiceOne.Views;

namespace ServiceOne
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      DBModel.CreateDatabase("ServiceOne");
      DBModel.CreateTables();
      // DBAddData.InsertValues();
      // DBModel.DropDatabase("ServiceOne");

      // Test Area
      // DBCrudTest.Run();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormMain());
    }
  }
}