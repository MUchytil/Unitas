using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Unitas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Unitas.Pages
{
    public partial class Index
    {
        [Inject]
        ApplicationDbContext appDbContext { get; set; }
        [Inject]
        UserManager<ApplicationUser> UserManager { get; set; }
        public async Task seedData()
        {
            //Council[] councils =
            //{
            //    new Council(0115,"St. Leo"  ,"7400854444" ,new Address("Houston "   ,"TX")),
            //    new Council(4805,"Msgr Bob" ,"9202885455" ,new Address("Green Bay"  ,"WI")),
            //    new Council(7895,"Msgr Gehl","9202885466" ,new Address("Hortonville","WI")),
            //    new Council(5494,"St. Mary" ,"8205493334" ,new Address("Greenville" ,"WI")),
            //    new Council(9154,"St. Pius" ,"9202744592" ,new Address("Appleton"   ,"WI"))
            //};

            //appDbContext.Councils.Add(new Council(0115, "St. Leo", "7400854444", new Address("Houston ", "TX")));
            //var x = appDbContext.SaveChanges();


            //ApplicationUser[] members =
            //{
            //    new ApplicationUser("Matthew" , "Uchytil"   ,"Matthew@outlook.com" ,new DateTime(1997,10,22),councils[0].Address,councils[1]),
            //    new ApplicationUser("John "   , "Smith"     ,"John@outlook.com"    ,new DateTime(1990,10,22),councils[1].Address,councils[0]),
            //    new ApplicationUser("Kennith" , "Rutherford","Kennith@outlook.com" ,new DateTime(1980,10,22),councils[2].Address,councils[3]),
            //    new ApplicationUser("Bernard" , "Smith"     ,"Bernard@outlook.com" ,new DateTime(1902,10,22),councils[3].Address,councils[2]),
            //    new ApplicationUser("Daniel"  , "Kennedy"   ,"Daniel@outlook.com"  ,new DateTime(2000,10,22),councils[4].Address,councils[0]),
            //    new ApplicationUser("Porco"   , "Rosso"     ,"Porco@outlook.com"   ,new DateTime(1986,10,22),councils[4].Address,councils[2]),
            //    new ApplicationUser("Edward"  , "Elric"     ,"Edward@outlook.com"  ,new DateTime(1969,10,22),councils[0].Address,councils[0]),
            //    new ApplicationUser("Alphonse", "Elric"     ,"Alphons@outlook.com" ,new DateTime(1972,10,22),councils[0].Address,councils[4]),
            //    new ApplicationUser("Joe"     , "Uchytil"   ,"Joe@outlook.com"     ,new DateTime(1942,10,22),councils[4].Address,councils[2]),
            //    new ApplicationUser("Marcus"  , "Uchytil"   ,"Marcus@outlook.com"  ,new DateTime(1955,10,22),councils[3].Address,councils[3]),
            //    new ApplicationUser("Cassy"   , "Engal"     ,"Cassy@outlook.com"   ,new DateTime(1989,10,22),councils[4].Address,councils[3]),

            //};

            //foreach (var mbr in members)
            //{
            //    var res = await UserManager.CreateAsync(mbr, $"{mbr.FirstName}{mbr.LastName}123!");
            //}


        }
    }
}
