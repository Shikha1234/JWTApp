using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "shikha_admin", EmailAddress = "shikha.admin@email.com", 
                Password = "MyPass_w0rd", GivenName = "Shikha", Surname = "Pandey", 
                Role = "Administrator" },
            new UserModel() { Username = "elyse_seller", EmailAddress = "elyse.seller@email.com", 
                Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Lambert", 
                Role = "Seller" },
        };
    }
}
