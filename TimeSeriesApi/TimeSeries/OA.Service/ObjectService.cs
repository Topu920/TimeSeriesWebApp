using OA.Data.Entities;
using OA.Repo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Object = OA.Data.Entities.Object;

namespace OA.Service
{
    public class ObjectService : IObjectService
    {
        private IObjectRepository<Object> objectRepository;
        public ObjectService(IObjectRepository<Object> objectRepository)
        {
            this.objectRepository = objectRepository;
        }
        public async Task<IEnumerable<Object>> GetObjects()
        {
            return await objectRepository.GetAll();
        }
    }
}
