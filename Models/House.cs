using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace Demo3.Models
{
    public class House
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name ="Owner's Name")]
        [DataType(DataType.Text)]
        public string? OwnersName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Property Name")]
        [DataType(DataType.Text)]
        public string? myProperty { get; set; }

        [Required]
        [Display(Name = "Property Value")]
        [DataType(DataType.Currency)]
        public int PropertyValue { get; set; }
    }
}
