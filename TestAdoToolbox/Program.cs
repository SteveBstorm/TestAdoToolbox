// See https://aka.ms/new-console-template for more information
using AdoToolbox;
using TestAdoToolbox;

Console.WriteLine("Hello, World!");

string cs = @"Data Source=DESKTOP-RGPQP6I\TFTIC2019;Initial Catalog=ADOStudent;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

//Connection cnx = new Connection(cs);
//Command cmd = new Command("INSERT INTO maTable (Nom) VALUES (@nom)");
//cmd.AddParameter("nom", "Arthur");

//Console.WriteLine(cnx.ExecuteNonQuery(cmd)); 

Connection cnx = new Connection(cs);
string sql = "SELECT * FROM Section";
Command cmd = new Command(sql);

foreach (Section item in cnx.ExecuteReader(cmd, Section.Converter))
{
    Console.WriteLine(item.Id + " - " + item.SectionName);
}