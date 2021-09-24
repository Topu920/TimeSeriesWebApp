using OA.Data.Entities;
using OA.Repo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class DataFieldService : IDataFieldService
    {
        private IDataFieldRepository<DataField> fieldRepository;
        public DataFieldService(IDataFieldRepository<DataField> fieldRepository)
        {
            this.fieldRepository = fieldRepository;
        }
        

        public async Task<IEnumerable<DataField>> GetDataFields()
        {
            return await fieldRepository.GetAll();
        }
    }
}
