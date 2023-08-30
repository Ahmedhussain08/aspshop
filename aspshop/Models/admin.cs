using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace aspshop.Models
{
    public class admin
    {
        [Key]
        public int id{ get; set; }
        public string username{ get; set; }
        public string password{ get; set; }
    }
}
