using System.ComponentModel.DataAnnotations;

namespace MicroFinance.Models
{
    public class Company
    {
        [Key]
        public int id { get; set; }
        public string ?CompanyName { get; set; }
        public string ?LogoURL { get; set; }
        public DateOnly CreatedDate { get; set; }
        public DateOnly ExperyDate { get; set; }
        public string ?Name { get; set; }
        public string ?MobileNumber { get; set; }
        public string ?EmailId { get; set; }
        public string ?Password { get; set; }
        public string ?ConformPassword { get; set; }
        public string? IsActive { get; set; }
        public string? IsDeleted { get; set; }
    }
}
