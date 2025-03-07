using Microsoft.AspNetCore.Authorization;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace TeamRedBlazor.Client.Server.Data.Models
{       
    
    public class RealEstateModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(1500)]
        public string Description { get; set; }

        [Required]
        public int Type { get; set; }
        public int RentingPrice { get; set; }
        public int PurchasePrice { get; set; }
        public bool CanBeRented { get; set; }
        public bool CanBePurchased { get; set; }
        public string Contact { get; set; }

        [Required]
        public string ConstructionYear { get; set; }

        [Required]
        public DateTimeOffset adCreated { get; set; }

    }
}
