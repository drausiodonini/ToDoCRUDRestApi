using ToDoCRUDRestApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ToDoCRUDRestApi.DataContext
{
  public class ToDoDataContext : DbContext
  {
    public ToDoDataContext(DbContextOptions<ToDoDataContext> options)
      :base(options)
    { }

    public virtual DbSet<ToDoModel> Todos { get; set; }
  }
}