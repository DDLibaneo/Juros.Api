using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Juros.Models.Entities
{
    public class Juro
    {
        public int Id { get; set; }

        [Required]
        public decimal Taxa { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
