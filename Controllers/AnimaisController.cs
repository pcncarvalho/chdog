using AutoMapper;
using chdog.Models;
using chdog.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chdog.Resources;

namespace chdog.Controllers 
{
    public class AnimaisController : Controller 
    {
        private readonly CHDogDbContext context;
        private readonly IMapper mapper;

        public AnimaisController (CHDogDbContext context, IMapper mapper) 
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet ("/api/animais")]
        public async Task<IEnumerable<AnimalResource>> GetAnimais() 
        {
            var animais = await context.Animais.Include (p => p.Raca).ToListAsync();

            return mapper.Map<List<Animal>, List<AnimalResource>>(animais);
        }
    }
}