using System;

namespace Codetown.Biuromat.Web.Data.Entities
{
    public class RoomEntity : BaseEntity
    {
        public string Name { get; set; }
        public string AccessCode { get; set; }

        public BuildingEntity Building { get; set; }
    }
}