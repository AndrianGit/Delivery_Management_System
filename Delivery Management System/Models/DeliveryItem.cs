using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Delivery_Management_System.Models
{
    public class DeliveryItem
    {
        [Key]
        public int Id { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryDescription { get; set; }
        public string DeliveryStatus { get; set; }
    }
}