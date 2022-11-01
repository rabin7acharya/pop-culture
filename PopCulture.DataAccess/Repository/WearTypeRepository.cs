using PopCulture.DataAccess.Repository.IRepository;
using PopCulture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCulture.DataAccess.Repository
{
    public class WearTypeRepository : Repository<WearType>, IWearTypeRepository
    {
        private ApplicationDbContext _db;

        public WearTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(WearType obj)
        {
            _db.WearTypes.Update(obj);
        }
    }
}
