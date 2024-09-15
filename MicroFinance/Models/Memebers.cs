using System.ComponentModel.DataAnnotations.Schema;

namespace MicroFinance.Models
{
    public class Memebers
    {
        public int MemberId { get; set; }
        public string ?MemberName { get; set; }
        public string ?MemberMobileNum { get; set; }

        public string? MemberIdentityUrl { get; set; }
       
        public string? MemberDocumentId { get; set; } // ForenKey banan hai
        public string? MemberSpounseName { get; set; }
        public string? MemberSpounseIdentityProof { get; set; }
        public string? MemberVillage { get; set; }
        public string? AccountNumber { get; set; }
        public string? ConformAccountNumber { get; set; }
        public string? MemberBankName { get; set; }
        public string? MemberBankBranche { get; set; }
        public string ?IFSC_Code { get; set; }
        public string? LoanAmount { get; set; }
        public DateOnly CreateDate { get; set; }
        public string? States { get; set; }
        public DateOnly MemberApprovalDate { get; set; }
      
        public int MemberCenterId { get; set; } // Foren Key 
    }
}
