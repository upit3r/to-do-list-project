using System.Collections.Generic;
using System.Linq;
using Project.Models;

namespace Project.Data{
    public class SqlProjectRepository : IProjectRepository{
        private readonly ProjectContext _context;

        public SqlProjectRepository(ProjectContext context){
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands(){
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id){
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}