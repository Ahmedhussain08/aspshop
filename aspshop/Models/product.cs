using System.ComponentModel.DataAnnotations;

namespace aspshop.Models
{
    public class product
    {
        [Key]
        public int proID { get; set; }
        public string pname { get; set; }
        public string pdesc { get; set; }
        public int pprice { get; set; } 

        public int catID { get; set; }
        public category category { get; set; }
        public int brandID { get; set; }
        public brand brand{ get; set; }

        public string Imagepath { get; set; }

    }
}
