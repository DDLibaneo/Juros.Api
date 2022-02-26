﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Juros.Models.Entities
{
    public class Juro
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        [Range(0, 999.99)]
        public decimal Taxa { get; set; }
    }
}
