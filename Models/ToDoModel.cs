using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoCRUDRestApi.Models
{
  public class ToDoModel {
    [Key]
    public int Id { get; set; }

    //[Required]
    [StringLength(45)]
    public string Title { get; set; }

    //[Required]
    [StringLength(500)]
    public string Description { get; set; }
  }
}