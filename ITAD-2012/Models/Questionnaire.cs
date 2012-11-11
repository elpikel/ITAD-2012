using System;
using System.ComponentModel.DataAnnotations;

namespace ITAD_2012.Models
{
    public class Questionnaire
    {
        public string Question { get; set; }
        [Required]
        public bool Answer { get; set; }
        public Guid Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public Questionnaire()
        {
            Id = Guid.NewGuid();
        }
    }
}