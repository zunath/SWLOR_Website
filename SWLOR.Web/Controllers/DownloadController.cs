using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace SWLOR.Web.Controllers
{
    public class DownloadController : Controller
    {
        public async Task<IActionResult> GUIDownload()
        {
            var ms = new MemoryStream();
            using (var stream = new FileStream("Files/SWLOR_GUI.zip", FileMode.Open))
            {
                await stream.CopyToAsync(ms);
            }

            ms.Position = 0;

            return File(ms, MediaTypeNames.Application.Zip, "SWLOR_GUI.zip");
        }
    }
}