using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace RandomDrawingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawController : ControllerBase
    {
        private Random rnd = new Random();
        [HttpGet("draw")]
        public ActionResult Draw()
        {
            var random_color=GetRandomColor();
        }

        private int[] GetRandomShape()
        {
            return
            [
                rnd.Next(350),
                rnd.Next(350),
                rnd.Next(350)
            ];
        }

        private KnownColor GetRandomColor()
        {
            var colors = Enum.GetValues(typeof(KnownColor));
            return (KnownColor)colors.GetValue(rnd.Next(colors.Length));
        }

    }
}
