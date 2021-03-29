using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFood.Models;
using System.Web.Http;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace FishFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameTextController : ControllerBase
    {
        List<GameText> gameTextList = new List<GameText>
        {
            new GameText("placeholder text")
        };

        public IEnumerable<GameText> GetAllText()
        {
            return gameTextList;
        }


        [Route("api/[controller]/failed")]
        public IHttpActionResult GetText(int id)
        {
            var text = gameTextList.FirstOrDefault((p) => p.Id == id);
            if (text == null)
            {
                return (IHttpActionResult)NotFound();
            }
            return (IHttpActionResult)Ok(text);
        }

    }
}
