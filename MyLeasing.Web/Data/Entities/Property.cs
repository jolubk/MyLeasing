using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [Display(Name = "Neighborhood*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Address*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }

        [Display(Name = "Price*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public string Price { get; set; }

        [Display(Name = "Square meters*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string SquareMeters { get; set; }

        [Display(Name = "Rooms*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Rooms { get; set; }

        [Display(Name = "Stratum*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Stratum { get; set; }

        [Display(Name = "Has Parking Lot?")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string HasParkingLot { get; set; }

        [Display(Name = "Is Available?")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string IsAvailable { get; set; }

        public string Remarks { get; set; }

        public PropertyType PropertyType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<PropertyImage> PropertyImages { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
