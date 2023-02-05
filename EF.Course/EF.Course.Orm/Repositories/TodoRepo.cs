using EF.Course.Model;
using EF.Course.Orm.Context;

using Microsoft.EntityFrameworkCore;

namespace EF.Course.Orm.Repositories
{
    public class TodoRepo : IEntityRepo<Todo>
    {
        public void Add(Todo entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbTodo = context.Todos.Where(todo => todo.Id == id).SingleOrDefault();
            if (dbTodo is null)
                return;
            context.Remove(dbTodo);
            context.SaveChanges();
        }

        public IList<Todo> GetAll()
        {
            using var context = new AppDbContext();
            return context.Todos.Include(todo => todo.TodoInfo).Include(todo => todo.TodoComments).ToList();
        }

        public Todo? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Todos.Where(todo => todo.Id == id)
                .Include(todo => todo.TodoInfo)
                .Include(todo => todo.TodoComments).SingleOrDefault();
        }

        public void Update(int id, Todo entity)
        {
            using var context = new AppDbContext();
            var dbTodo = context.Todos.Where(todo => todo.Id == id).SingleOrDefault();
            if (dbTodo is null)
                return;
            dbTodo.Title = entity.Title;
            dbTodo.Finished = entity.Finished;
            dbTodo.TodoComments = entity.TodoComments;
            dbTodo.TodoInfo = entity.TodoInfo;
            context.SaveChanges();
        }
    }
}
