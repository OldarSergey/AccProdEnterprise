namespace AccProdEnterprise.Entities
{
    public class AdvancedTrainingCourse
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string NameOfCourse { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public string Category { get; set; }
        public string Organizer { get; set; }



        //public ICollection<Employee> Employees { get; set; }



    }
}
