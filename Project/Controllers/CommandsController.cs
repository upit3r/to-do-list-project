using System.Collections.Generic;
using Project.Data;
using Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers{
    //api commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase{
        private readonly IProjectRepository _repository;

        public CommandsController(IProjectRepository repository){
            _repository = repository;
        }
        //private readonly MockProjectRepository _repository = new MockProjectRepository();
        //GET api/commands - all commands without id
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands(){
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        //GET api/commands/{id} ex:api/commands/5
        [HttpGet("{id}")]

        public ActionResult <Command> GetCommandById(int id){
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }

    }
}