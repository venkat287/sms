using SMS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SMS
{
    public class InspectionsDataStore
    {
        public List<InspectionInfo> Inspections { get; set; }

        public static InspectionsDataStore CurrentInstance { get; } = new InspectionsDataStore();

        public InspectionsDataStore()
        {

            // Get the solution directory
            string solutionDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\"));
            string filePath = Path.Combine(solutionDirectory, "Mock.json");

            string jsonString = File.ReadAllText(filePath);

            // Deserialize JSON to a list of Inspection objects
            List<InspectionInfo> inspections = JsonSerializer.Deserialize<List<InspectionInfo>>(jsonString);

        }
    }
}
