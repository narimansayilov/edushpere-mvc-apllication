using System.ComponentModel.DataAnnotations;

namespace EduSphere.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Course Course { get; set; } 
        public int Quantity { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
