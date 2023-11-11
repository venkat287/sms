using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class InspectionDetail
    {
        public string Category { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }

    public class Inspector
    {
        public int InspectorId { get; set; }
        public string Name { get; set; }
    }

    public class InspectionInfo
    {
        [Primary]
        public int InspectionId { get; set; }
        public DateTime Date { get; set; }
        public School School { get; set; }
        public Inspector Inspector { get; set; }
        public List<InspectionDetail> InspectionDetails { get; set; }
    }

    public class School
    {
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }

}
