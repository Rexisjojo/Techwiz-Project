using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace eStudies.Models
{
    public class Marks
    {
        public int Id { get; set; }
        [Display(Name = "Student Marks")]
        public int SMarks { get; set; }

        public int RegisterId { get; set; }
        public Register Register { get; set; }

    }

    public class AcademicProgress
    {
        public int Id { get; set; }
        [Display(Name = "Student Progress")]

        public string Progress { get; set; }
        public int RegisterId { get; set; }

        public Register Register { get; set; }
    }

    public class SResources
    {
        public int Id { get; set; }

        public string Book { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Date of Extra Classes")]

        public DateTime DOE { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Time of Extra Classes")]

        public string ExTime { get; set; }
        public int RegisterId { get; set; }

        public Register Register { get; set; }
    }
}
