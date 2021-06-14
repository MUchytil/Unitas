using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Unitas.Data
{
    public class Address
    {
        [Required]
        public int Id { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
        [Required]
        [MaxLength(2)]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        public int Zipcode { get; set; }
    }
}
