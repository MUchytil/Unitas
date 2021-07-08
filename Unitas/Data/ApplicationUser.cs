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

    }
}
