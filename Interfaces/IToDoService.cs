using System;
using System.Collections.Generic;
using ToDoCRUDRestApi.DataContext;
using ToDoCRUDRestApi.Models;

namespace ToDoCRUDRestApi.Interfaces
{
  public interface IToDoService
  {
      List<ToDoModel> GetToDos(ToDoDataContext context);

      ToDoModel GetToDo(ToDoDataContext context, int id);
  
      ToDoModel SaveToDo(ToDoDataContext context, ToDoModel toDo);

      ToDoModel UpdateToDo(ToDoDataContext context, int id, ToDoModel toDo);

      void DeleteToDo(ToDoDataContext context, int id);
  }
}