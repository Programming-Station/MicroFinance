using System.ComponentModel.DataAnnotations.Schema;

namespace MicroFinance.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string ?UserName { get; set; }
        public string ?UserProfileImage { get; set; }
        public string ?UserAddress { get; set; }
        public string ?UserPinCoad { get; set; }
        public string ?UserEmailId { get; set; }
        public string ?UserMobileNumber { get; set; }
        public DateOnly UserDateOfBirthday { get; set; }
        public string ?Gender { get; set; }
        public string ?UserPassword { get; set; }
        public string ?UserConformPassword { get; set; }

        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }


    }
}
