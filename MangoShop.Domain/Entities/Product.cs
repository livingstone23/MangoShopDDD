using System.ComponentModel.DataAnnotations;
using System.Diagnostics;



namespace MangoShop.Domain.Entities;



public class Product: Entity
{
    public Guid Oid { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Description { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    public decimal Price { get; set; }

}