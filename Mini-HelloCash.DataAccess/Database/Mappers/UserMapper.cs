using Mini_HelloCash.DataAccess.Core;
using Mini_HelloCash.DataAccess.Database.Entities;
using Mini_HelloCash.Models;

namespace Mini_HelloCash.DataAccess.Database.Mappers
{
    internal class UserMapper : IMapper<UserModel, User>
    {
        public User Map(UserModel source)
        {
            return new()
            {
                Id = source.Id,
                Email = source.Email,
                Username = source.Username,
                PasswordHash = source.Password,
                RoleId = source.RoleId,
            };
        }
    }
}
