using System.Collections.Generic;
using Project.Models;

namespace Project.Data{
    public interface IProjectRepository{
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int Id);
    }
}