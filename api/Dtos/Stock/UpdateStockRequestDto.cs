using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol can not be over 10 caracters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(255, ErrorMessage = "CompanyName can not be over 255 caracters")]
        public string CompanyName { get; set; } = string.Empty;


        [Required]
        [Range(1, 1000000000, ErrorMessage = "Purchase must be 1 - 1000000000")]
        public decimal Purchase { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "div must be 1 - 100")]
        public decimal LstDiv { get; set; }


        [Required]
        [MaxLength(10, ErrorMessage = "Industry can not be over 10 caracters")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 500000000, ErrorMessage = "MarketCap must be 1 - 500000000")]
        public long MarketCap { get; set; }
    }
}