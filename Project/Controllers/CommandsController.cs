using System.Collections.Generic;
using Project.Data;
using Project.Models;
using Project.Dtos;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Project.Controllers{
    //api commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase{
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public CommandsController(IProjectRepository repository, IMapper mapper){
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockProjectRepository _repository = new MockProjectRepository();

        //GET api/commands - all commands without id
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands(){
            var commandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        //GET api/commands/{id} ex:api/commands/5
        [HttpGet("{id}")]

        public ActionResult <CommandReadDto> GetCommandById(int id){
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null){
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
            
        }

    }
}