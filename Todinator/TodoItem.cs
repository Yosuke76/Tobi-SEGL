//KLasse => Eigener Datentyp
public class TodoItem
{
    // Klassen definieren Variablen (Daten) und Methoden(Funktionalität)
    //Variablen können Felder (Fields) oder Eigenschaften(Properties) sein
    // Felder sind privat -> Klassenintern
    // Eigenschaften ist public -> Kann von außen aufgerufen werden.
    public string Description { get; set; }
    public int Prio { get; set; }
}
