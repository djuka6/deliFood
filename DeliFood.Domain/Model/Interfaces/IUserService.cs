using DeliFood.Domain.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliFood.Domain.Model.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<User> GetAll();
        public User GetById(Guid id);

        string Authenticate(AuthenticateRequest model);
        string Register(RegistrationRequest model);


    }
}
