using AccProdEnterprise.Entities.Enums;

namespace AccProdEnterprise.Entities
{
    public class VacationApplication
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateOfSubmission { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public int QtyOfDays { get; set; }
        public StatusApplication StatusApplication { get; set; }
        public string? RejectsReason { get; set; }

        public int StaffDepartmentId { get; set; }
        public StaffDepartment StaffDepartment{ get; set; }


    }
}
