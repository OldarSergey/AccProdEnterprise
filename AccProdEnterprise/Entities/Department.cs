namespace AccProdEnterprise.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string NameDepartment { get; set; }
        public string Description { get; set; }
        public string FullNameOfTheHead { get; set; }


        public ICollection<Employee> Employees { get; set; }

        //public int StaffDepartmentId{ get; set; }
        //public StaffDepartment StaffDepartment{ get; set; }
    }
}
