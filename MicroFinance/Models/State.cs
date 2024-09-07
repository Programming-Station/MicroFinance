using System.ComponentModel.DataAnnotations;

namespace MicroFinance.Models
{
    public class State
    {
        public State()
        { 
            Cities   = new HashSet<City>();
            Branch=new HashSet<Branch>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public string IsActive { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<Branch> Branch { get; set; }
    }
}
