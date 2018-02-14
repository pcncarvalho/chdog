using AutoMapper;
using chdog.Models;
using chdog.Resources;

namespace chdog.Mapping {
    public class MappingProfile : Profile 
    {
        public MappingProfile () 
        {
            CreateMap<Animal, AnimalResource> ();
            CreateMap<Raca, RacaResource> ();
        }
    }
}