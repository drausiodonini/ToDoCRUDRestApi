using System;
using System.Collections.Generic;
using System.Linq;
using ToDoCRUDRestApi.DataContext;
using ToDoCRUDRestApi.Interfaces;
using ToDoCRUDRestApi.Models;

namespace ToDoCRUDRestApi.Services
{
  public class TodoService : IToDoService
  {
    public List<ToDoModel> GetToDos(ToDoDataContext context)
    {
      return context.Todos.ToList();
    } 

    public ToDoModel GetToDo(ToDoDataContext context, int Id)
    {
      return context.Todos.FirstOrDefault(x => x.Id == Id);
    }

    public ToDoModel UpdateToDo(ToDoDataContext context, int id, ToDoModel toDo)
    {
      ToDoModel entity = context.Todos.FirstOrDefault(x => x.Id == id);

      if (entity == null)
      {
        context.Todos.Add( toDo );

        context.SaveChanges();
        return toDo;
      } else 
      {
        entity.Title = toDo.Title;
        entity.Description = toDo.Description;

        context.SaveChanges();
        return entity;
      }
    }

    public ToDoModel SaveToDo(ToDoDataContext context, ToDoModel toDo)
    {
        context.Todos.Add( toDo );
        context.SaveChanges();
        return toDo;
    }

    public void DeleteToDo(ToDoDataContext context, int id)
    {
      ToDoModel entity = context.Todos.FirstOrDefault(x => x.Id == id);

      if (entity != null)
      {
        context.Todos.Remove(entity);
        context.SaveChanges();
      }
    }
  }
}