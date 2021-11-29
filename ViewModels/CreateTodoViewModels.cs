using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;
using Flunt.Notifications;

namespace MiniTodo.ViewModels
{
  public class CreateTodoViewModels : Notifiable<Notification>
  {
    public string Title { get; set; }

    public Todo MapTo()
    {
      // var contract = new Contract<Notification>()
      // .Requires()
      // .IsNotNull(Title, "Informar o Título da tarefa")
      // .IsGreaterThan(Title, 5, "Título deve ter no mínimo 5 caracteres");

      // AddNotification(contract);

      return new Todo(Guid.NewGuid(), Title, false);
    }
  }
}