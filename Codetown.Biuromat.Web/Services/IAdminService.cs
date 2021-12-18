using System.Collections;
using System.Collections.Generic;
using Codetown.Biuromat.Web.Data.Entities;

namespace Codetown.Biuromat.Web.Services
{
    public interface IAdminService
    {
        public ICollection<BuildingEntity> GetBuildingList();
        public BuildingEntity GetOneBuilding(int id);

        public void SeedBuldings();
    }
}