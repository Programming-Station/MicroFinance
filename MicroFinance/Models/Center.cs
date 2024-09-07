using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroFinance.Models
{
    
    public class Center
    {
       
        [Key]
        public int CneterId { get; set; }
        public string CenterName { get; set; }
        public string CenterAddress { get; set; }
        public string CnetePinCoad { get; set; }

        [ForeignKey("BrancId")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        
        
    }
}
