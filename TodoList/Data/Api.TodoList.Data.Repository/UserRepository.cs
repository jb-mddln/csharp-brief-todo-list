using Api.TodoList.Data.Context.Contract;
using Api.TodoList.Data.Entity.Model;

namespace Api.TodoList.Data.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(ITodoListDbContext dbContext) : base(dbContext)
        {
        }
    }
}