using System;
using Microsoft.AspNetCore.Identity;

namespace Codetown.Biuromat.Web.Data.Entities
{
    public class UserEntity : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTwitter { get; set; }
        public string ContactWhatsapp { get; set; }
    }
}