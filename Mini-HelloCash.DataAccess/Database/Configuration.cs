using Microsoft.Extensions.DependencyInjection;
using Mini_HelloCash.DataAccess.Core;
using Mini_HelloCash.DataAccess.Database.Daos;
using Mini_HelloCash.DataAccess.Database.Daos.Interfaces;
using Mini_HelloCash.DataAccess.Database.Entities;
using Mini_HelloCash.DataAccess.Database.Mappers;
using Mini_HelloCash.Models;

namespace Mini_HelloCash.DataAccess.Database;

public static class Configuration
{
    public static void ConfigureDatabase(this IServiceCollection serviceCollection)
    {
        serviceCollection.ConfigureDao();
        serviceCollection.ConfigureMappers();
    }

    private static void ConfigureDao(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IUserDao, UserDao>();
        serviceCollection.AddSingleton<IRoleDao, RoleDao>();
    }

    private static void ConfigureMappers(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IMapper<UserModel, User>, UserMapper>();
    }
}
