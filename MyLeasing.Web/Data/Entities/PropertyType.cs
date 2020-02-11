using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Display(Name ="Property Type")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}
