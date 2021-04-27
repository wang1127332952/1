using Hgtech.Control.Infrastructure.Interceptor.HandlerAttributes;
using Hgtech.Control.Infrastructure.Models;
using System.Collections.Generic;

namespace Hgtech.Control.Infrastructure.IServices
{
    [LogHandler]
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}
