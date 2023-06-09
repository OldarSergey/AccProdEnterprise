namespace AccProdEnterprise.Entities
{
    public class Tablesheet
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string QtyHoursWorked { get; set; }
        public string TypeWork { get; set; }


        public ICollection<Employee> Employees { get; set; }
    }
}
