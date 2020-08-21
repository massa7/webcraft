// using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product
    {
         [Key]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
    }
}