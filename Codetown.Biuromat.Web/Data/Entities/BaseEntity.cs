using System;
using Microsoft.AspNetCore.Mvc;

namespace Codetown.Biuromat.Web.Data.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}