using AutoMapper;
using Project.Dtos;
using Project.Models;

namespace Project.Profiles{
    public class CommandsProfile : Profile{
        public CommandsProfile(){
            CreateMap<Command, CommandReadDto>();
        }
    }
}