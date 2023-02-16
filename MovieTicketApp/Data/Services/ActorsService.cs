using Microsoft.EntityFrameworkCore;
using MovieTicketApp.Models;

namespace MovieTicketApp.Data.Services
{
    public class ActorsService : IActorsService
    {
        static readonly AppDbContext context;

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await context.Actors.ToListAsync();
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
