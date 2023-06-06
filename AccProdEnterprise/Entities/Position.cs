namespace AccProdEnterprise.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string NamePost { get; set; }
        public string Descripton { get; set; }
        public decimal Salary { get; set; }
        public string EducationRequirement { get; set; }
        public DateTime DateOfCreate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime DateOfDelete { get; set; }


        public ICollection<Employee> Employees { get; set; }

    }
}
