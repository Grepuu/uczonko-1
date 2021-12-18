using System;
using System.Collections;
using System.Collections.Generic;

namespace Codetown.Biuromat.Web.Data.Entities
{
    public class BuildingEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<RoomEntity> Rooms { get; set; }
    }
}