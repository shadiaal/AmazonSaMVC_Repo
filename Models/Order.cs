using System;
using System.ComponentModel.DataAnnotations;
namespace AmazonSaMVC.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required]
        public string UserId { get; set; } 

        [Required]
        public DateTime OrderDate { get; set; }

        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }


    }
}

