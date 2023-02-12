using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_br333.Models
{
    //The FormID is the primary key
    //this class contains the inputs for each item in the form with getters and setters. There are also certain fields that are requried and one the has a length limit.
    public class FormResponse
    {
        [Key]
        [Required]
        public int FormID { get; set; }

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
