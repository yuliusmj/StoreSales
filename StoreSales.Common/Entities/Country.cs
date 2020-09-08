using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreSales.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} can no have more than {1} characters.")]
        [Required(ErrorMessage ="This field {0} is required")]
        public string Name { get; set; }
    }
}
