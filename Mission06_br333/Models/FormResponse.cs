using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_br333.Models
{
    public class FormResponse
    {
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public short Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public string Lent_to { get; set; }

        public bool Edited { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
