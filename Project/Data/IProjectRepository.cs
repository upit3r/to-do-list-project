using System.Collections.Generic;
using Project.Models;

namespace Project.Data{
    public interface IProjectRepository{
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int Id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);

    }
}