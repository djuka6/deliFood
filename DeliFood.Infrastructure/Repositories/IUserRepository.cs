using DeliFood.Infrastructure.DBO;
using DeliFood.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliFood.Infrastructure.Repositories
{
    public interface IUserRepository : IBaseRepository<int, UserDbo>
    {
        public UserDbo GetById(Guid id);
    }
}
