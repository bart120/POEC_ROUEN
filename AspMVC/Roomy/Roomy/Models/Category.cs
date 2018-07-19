using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class Category : BaseModel
    {
        [Required (ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name="Libélle")]
        [StringLength(20)]
        public string Name { get; set; }
    }
}