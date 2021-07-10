using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Unitas.Data
{
    public class Council
    {
        public Council() {}
        public Council(int number, string name, string phoneNumber, Address address)
        {
            CouncilNumber = number; ;
            CouncilName = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }


        /// <summary>
        /// number of council
        /// Example: council #7895
        /// </summary>
        [Key]
        [Required]
        public int CouncilNumber { get; set; }
        /// <summary>
        /// Name of council
        /// Example: Msgr. Gehl Council
        /// </summary>
        public string CouncilName { get; set; }
        public Address Address { get; set; }
        
        /// <summary>
        /// used to get in contact with the council
        /// </summary>
        [Phone]
        public string PhoneNumber { get; set;}

        

    }
}
