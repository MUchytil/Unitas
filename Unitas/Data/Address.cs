using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Unitas.Data
{
    public class Address
    {
        public Address(int id, string city, string state)
        {
            Id = id;
            City = city;
            State = state;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [MaxLength(2)]
        public string State { get; set; }
        
        public string Country { get; set; }
        public int Zipcode { get; set; }
        
    }
}
