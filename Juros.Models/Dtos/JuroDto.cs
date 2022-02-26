using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Juros.Models.Dtos
{
    public class JuroDto
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$")]        
        public decimal Taxa { get; set; }
    }
}
