namespace AccProdEnterprise.Entities
{
    public class StaffDepartment
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }


        public ICollection<Department> Departments { get; set; }
        public ICollection<AdmissionDismissalOrder> AdmissionDismissalOrders { get; set; } 
        public ICollection<VacationApplication> VacationApplications{ get; set; }
   


    }
}
