namespace MicroFinance.Models
{
    public class Role
    {
        public int Roleid { get; set; }
        public string ?RoalName { get; set; }
        public DateOnly CreateDate { get; set; }
        public string ?CreatedBy { get; set; }
        public string ?IsActive { get; set; }
        public string ?IsDeleted { get; set; }
    }
}
