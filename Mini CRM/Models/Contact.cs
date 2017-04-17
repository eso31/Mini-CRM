using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mini_CRM.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50,ErrorMessage ="Debe de ser menos de 50 caracteres")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Debe de ser un correo valido")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        //public int AnnotationId { get; set; }
        //[ForeignKey("AnnotationId")]
        public virtual ICollection<Annotation> Annotations { get; set; }

    }
}