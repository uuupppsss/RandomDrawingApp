using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace RandomDrawingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawController : ControllerBase
    {
        [HttpGet("draw")]
        public ActionResult Draw()
        {

        }

        private byte[] GetRandomShape()
        {

        }

        private KnownColor GetRandomColor()
        {
            Random rnd=new Random();
            var colors = Enum.GetValues(typeof(KnownColor));
            return (KnownColor)colors.GetValue(rnd.Next(colors.Length));
        }

    }
}
