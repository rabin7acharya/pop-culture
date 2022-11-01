using PopCulture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCulture.DataAccess.Repository.IRepository
{
    public interface IWearTypeRepository : IRepository<WearType>
    {
        void Update(WearType obj);
    }
}
