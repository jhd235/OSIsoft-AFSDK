using OSIsoft.AF;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Analysis;
using OSIsoft.AF.Search;
using System;
namespace PI_project
{
    class PI_project
    {
        static void Main(string[] args)
        {
            PISystems myPISystems = new PISystems();
            PISystem myPISystem = myPISystems.DefaultPISystem;
            if (myPISystem == null)
            throw new InvalidOperationException("Default PISystem was not found.");
            Console.WriteLine("Version of the PISystems = {0}", myPISystems.Version);

        }
    }
}