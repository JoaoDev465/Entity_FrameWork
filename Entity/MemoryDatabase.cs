using Microsoft.EntityFrameworkCore;

namespace Entity;

public  class MemoryDataBase
{
    // the most interessant fact about entity is use DataBase in your Stack Memory.
    public  void Query_From_InMemoryDB()
    {
        var context = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase("banana").Options;
        
        // opens Db with each hit.
        using var dbContext = new Context(context);
        
        // create the user.
        var user = new UserModel
        {
            Email = "joaoSouza@gmail.com",
            Id = Random.Shared.Next(1, 10),
            Old = 22,
            Name = "joão"

        };

        // save user data
        dbContext.UserModels.Add(user);
        dbContext.SaveChanges();

        var users = dbContext.UserModels.ToList();
        foreach (var client in users)
        {
            Console.WriteLine($"{client.Name}-{client.Email}-{client.Id}");
        }
    }
    
}

public class Context : DbContext
{
    // here you start your DB.
    public Context(DbContextOptions<Context> options) : base(options){}

    // Dbset to mapper entity user.
    public DbSet<UserModel> UserModels { get; set; }
}