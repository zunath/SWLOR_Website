using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities.Data;

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

            return File(System.IO.File.OpenRead(download.LocalPath), download.ContentType, download.FileName);
        }


    }
}
