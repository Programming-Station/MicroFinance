using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace MicroFinance.Models
{
    public class GovtDocumet
    {
       
        [Key]
        public int GovtId { get; set; }
        public string ?AdharCard { get; set; }
        public string ?PanCard { get; set; }
        public string ?DL { get; set; }


    }
   
}
