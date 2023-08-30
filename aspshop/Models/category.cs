using System.ComponentModel.DataAnnotations;

namespace aspshop.Models
{
    public class category
    {
        [Key]
        public int catID { get; set; }
        public string cname { get; set; }
        public ICollection<product> products { get; set; }
    }
}
