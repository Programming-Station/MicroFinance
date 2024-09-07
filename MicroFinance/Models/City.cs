using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroFinance.Models
{
    public class City
    {
       
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [ForeignKey("Statid")]
        public int Statid { get; set; }
        public State State { get; set; }

       
    }
}