using System.Security.Cryptography.X509Certificates;

namespace AccProdEnterprise.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string? Middlename { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }


        public int PositionName { get; set; }
        

        public int PositionId { get; set; }
        public Position Position { get; set; } 

        //public int TablesheetsId { get; set; }
        //public Tablesheet Tablesheet { get; set; }

        //public int AdvancedTrainingCourseId { get; set; }
        //public AdvancedTrainingCourse AdvancedTrainingCourse { get; set; }


        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
