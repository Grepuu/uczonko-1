using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using Codetown.Biuromat.Web.Data;
using Codetown.Biuromat.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codetown.Biuromat.Web.Services.Impl
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _dbContext;
        
        public AdminService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public ICollection<BuildingEntity> GetBuildingList()
        {
            return _dbContext.Buildings
                .Include(n => n.Rooms)
                .ToList();
        }

        public BuildingEntity GetOneBuilding(int id)
        {
            return _dbContext.Buildings
                .Include(n => n.Rooms)
                .FirstOrDefault(n => n.Id == id);
        }

        public void SeedBuldings()
        {
            var buldingOne = new BuildingEntity()
            {
                Name = "Siedziba główna",
                Address = "ul. Poniatowskiego 13",
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                IsActive = true
            };
            
            _dbContext.Buildings.Add(buldingOne);
            _dbContext.SaveChanges();

            var room = new RoomEntity()
            {
                Name = "Sala konferencyjna",
                AccessCode = "1234",
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                IsActive = true,
                Building = buldingOne
            };
            
            _dbContext.Rooms.Add(room);
            
            var buldingTwo = new BuildingEntity()
            {
                Name = "Magazyn",
                Address = "ul. Sikorskiego 9213/123a",
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                IsActive = true,
                Rooms = new List<RoomEntity>
                {
                    new RoomEntity()
                    {
                        Name = "Sala konferencyjna",
                        AccessCode = "1234",
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                        IsActive = true,
                        Building = buldingOne
                    }
                }
            };

            _dbContext.Buildings.Add(buldingTwo);
            _dbContext.SaveChanges();
        }
    }
}