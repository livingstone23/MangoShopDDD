using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MangoShop.Domain.Entities;



public class Client: Entity
{

    public Guid Oid { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The {0} is required")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Email { get; set; }

}

