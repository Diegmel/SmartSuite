using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartsuite.data.Repository
{
    interface IRepository
    {
        bool Insert(string id);
        bool Delete(string id);
        bool Update(string id);
    }
}
