using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Unitas.Data
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// First Name of user
        /// </summary>
        [Required]
        [PersonalData]
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of user
        /// </summary>
        [Required]
        [PersonalData]
        public string LastName { get; set; }
        /// <summary>
        /// Date of Birth
        /// </summary>
        [PersonalData]
        public DateTime DOB { get; set; }
        /// <summary>
        /// Address of user
        /// </summary>
        [PersonalData]
        public Address Address { get; set; }

        public Council CouncilMembership { get; set; }

        public ApplicationUser() { }
        public ApplicationUser(string firstName, string lastName, string email, DateTime dob, Address address, Council membership) {
            FirstName = firstName;
            LastName = lastName;
            UserName = email;
            Email = email;
            DOB = dob;
            Address = address;
            CouncilMembership = membership;
        }

        public string FullName => $"{FirstName} {LastName}";
        public int Age => DateTime.Now.Year - DOB.Year;
    }
}
