using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityTut.Models
{
    public class OfficeAssignment
    {
        [Key]//Vi InstructorID khong theo convention ID, ClassnameID -> can them attribute [key] de EF biet 
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}