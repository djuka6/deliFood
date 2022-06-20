using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliFood.Domain.Model.Interfaces
{
    public interface IUserInfrastructureService
    {
        public IEnumerable<User> GetAll();
        public void SaveUser(User user);
        public User GetById(Guid id);
    }
}
