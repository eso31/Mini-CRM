using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mini_CRM.Models
{
    public class Annotation
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public int ContactId { get; set; }

        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }
    }
}