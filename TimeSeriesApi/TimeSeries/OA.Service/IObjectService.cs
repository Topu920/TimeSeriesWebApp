using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OA.Data.Entities;
using Object = OA.Data.Entities.Object;
namespace OA.Service
{
    public interface IObjectService
    {
         Task<IEnumerable<Object>> GetObjects();
    }
}
