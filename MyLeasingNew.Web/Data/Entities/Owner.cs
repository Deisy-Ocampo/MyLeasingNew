using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasingNew.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {20} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {50} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {50} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Fixed Phone")]
        [MaxLength(20)]
        public string FixedPhone { get; set; }

        [Display(Name = "Cell Phone")]
        [MaxLength(20)]
        public string CellPhone { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Display(Name = "Owner Name")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Owner Name")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Properties{ get; set; }
        public ICollection<Contract> Contracts { get; set; }
        

    }
}
