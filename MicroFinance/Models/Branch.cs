using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroFinance.Models
{
    public class Branch
    {
        public Branch()
        {
            Center = new HashSet<Center>(Center);

        }
        [Key]
        public int BranchId { get; set; }
        public string ?BranchName { get; set; }
        public string ?BranchManager { get; set; }

        [ForeignKey("Statid")]
        public int Statid { get; set; }
        public State State { get; set; }

       public ICollection<Center> Center { get; set; }

    }
}
