# `serviceOne`
`serviceOne` ist ein c#-Projekt mit Windows Forms und einer MySQL-Datenbank 
im Rahmen des Umschulungsmoduls `c#-fortgeschritten`

## Projektkriterien des Bildungsträgers
- Erstellung einer Windows-Forms Anwendung
- Anbindung einer relationalen MySQL-Datenbank 
- Projektdauer waren effektiv 6 Tage

## Projektvorhaben
Erstellung eines Datenbankmanagementsystems für ein fiktives Unternehmen mit Ressourcenverwaltung
von Ersatzteilen, Besonderheit ist die Verwaltung unterschiedlicher Lager 
(Haupt- und Fahrzeuglager von Technikern im Aussendienst).

## Projektziele (eigene Anforderungen)
- Entwurf gemäß Model-View-Controller
- Implementierung unter Berücksichtigung OOP-Programmierung
- Vesionsverwaltung mit `git`

## Database / Model

![database.png](Ressources%2Fdatabase.png)

- [download]((https://github.com/P76ers/ServiceOne/blob/main/Ressources/serviceone.sql))
 or run `DBAddData.InsertValues();`
  
```c#
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
```

 


