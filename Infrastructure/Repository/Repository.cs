using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Entitites;
using Infrastructure.Generic;

namespace Infrastructure.Repository
{
    public interface ISinhVienRepository : IRepository<SinhVien>
    {

    }

    public class Repository : Repository<SinhVien>, ISinhVienRepository
    {
        public Repository(EXDbContext context) : base(context)
        {
        }
    }
}
