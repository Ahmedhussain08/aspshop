using System.ComponentModel.DataAnnotations;

namespace aspshop.Models
{
    public class brand
    {
        [Key]
        public int brandID { get; set; }
        public string bname { get; set; }
        public ICollection<product> products { get; set; }

    }
}
