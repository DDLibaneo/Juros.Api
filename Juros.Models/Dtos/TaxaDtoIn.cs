using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Juros.Models.Dtos
{
    public class TaxaDtoIn
    {
        [Required]
        public decimal Taxa { get; set; }
    }
}
