using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IDataFieldService
    {
         Task<IEnumerable<DataField>> GetDataFields();
    }
}
