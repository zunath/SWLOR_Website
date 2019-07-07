using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWLOR.Web.Data;

namespace SWLOR.Web.Controllers
{
    public class DownloadController: Controller
    {
        private readonly DataContext _db;

        public DownloadController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index(int id)
        {
            var download = _db.Download.SingleOrDefault(x => x.ID == id);
            if (download == null)
            {
                return Content("Download not found for ID " + id);
            }

            if (!System.IO.File.Exists(download.LocalPath))
            {
                return Content("File not found on server for ID " + id);
            }

            var fileInfo = new FileInfo(download.LocalPath);

            // Normally we'd call "return File(...);" but some files are really big,
            // so we don't want to buffer them into memory before sending to the client.
            Response.Clear();
            Response.ContentType = download.ContentType;
            Response.ContentLength = fileInfo.Length;
            Response.Headers.Add("Content-Disposition", "attachment; filename=" + download.FileName);

            using (var stream = System.IO.File.OpenRead(download.LocalPath))
            {
                stream.CopyTo(Response.Body);
            }

            return Ok(Response);
        }


    }
}
