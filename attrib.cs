using OSIsoft.AF;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Analysis;
using OSIsoft.AF.Search;
using System;
namespace PI_project{
class af{
	static void Main(string[] args) {
 PISystems myPISystems = new PISystems();
 PISystem myPISystem = myPISystems.DefaultPISystem;
 if (myPISystem == null)
     throw new InvalidOperationException("Default PISystem was not found.");
 AFDatabase myDB = myPISystem.Databases["PE"];
 if (myDB == null)
     throw new InvalidOperationException("Database was not found.");
AFElement element = myDB.Elements["El"];
int count;
using (var search = new AFAnalysisSearch(myDB, "MyAnalysisSearch", string.Format(@"Target:'{0}'", element.GetPath())))
{
    search.CacheTimeout = TimeSpan.FromMinutes(10);
    count = search.GetTotalCount();
    Console.WriteLine("Found {0} Analyses", count);
    foreach (var item in search.FindObjects(fullLoad: true))
    {
        Console.Write("Analysis Name = {0},", item.Name);
        Console.Write("Analysis Description = {0},", item.Description);
        Console.Write("Analysis Target = {0}", item.Target);
        Console.WriteLine();
    }
}
}
}
}