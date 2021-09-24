using OA.Data.Entities;
using OA.Repo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class BuildingService : IBuildingService
    {
        private IBuildingRepository<Building> buildingRepository1;
        public BuildingService(IBuildingRepository<Building> buildingRepository)
        {
            buildingRepository1 = buildingRepository;
        }
        public async Task<IEnumerable<Building>> GetBuildings()
        {
            return await buildingRepository1.GetAll();
        }
    }
}
