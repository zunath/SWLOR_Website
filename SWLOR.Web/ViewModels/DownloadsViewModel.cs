using System.Collections.Generic;
using System.Linq;
using DotNetify;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.ViewModels
{
    public class DownloadsViewModel: BaseVM
    {
        public IEnumerable<Downloads> DownloadList { get; set; }

        public DownloadsViewModel(DataContext db)
        {
            DownloadList = db.Downloads
                .Where(x => x.IsActive)
                .ToList();
        }
    }
}
