namespace AccProdEnterprise.Entities
{
    public class AdmissionDismissalOrder
    {
        public int Id { get; set; }
        public string TypeOfOrder { get; set; }
        public DateTime DateOfOrders { get; set; }
        public string ReasonOfDismissal { get; set; }

       

        public int StaffDepartmentId { get; set; }
        public StaffDepartment StaffDepartment{ get; set; }
    }
}
