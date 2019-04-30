using System.Linq;
using Alcantara.MusicCollection.Domain.Entities;
using Alcantara.MusicCollection.Infra.Context;
using Microsoft.AspNetCore.Mvc;

namespace Alcantara.MusicCollection.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly MusicCollectionContext context;

        public ArtistsController(MusicCollectionContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Artists.ToList());
        }

        [HttpPost]
        public IActionResult Post(Artist artist)
        {
            context.Artists.Add(artist);
            context.SaveChanges();

            return CreatedAtAction(nameof(Post), new { id = artist.Id }, artist);
        }
    }
}