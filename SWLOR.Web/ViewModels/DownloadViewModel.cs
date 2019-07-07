using System.Collections.Generic;
using System.Linq;
using DotNetify;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.ViewModels
{
    public class DownloadViewModel:BaseVM
    {
        public string DownloadList_itemkey => nameof(Download.ID);
        public IEnumerable<Download> DownloadList
        {
            get => Get<IEnumerable<Download>>();
            set => Set(value);
        }

        public DownloadViewModel(DataContext db)
        {
            DownloadList = db.Download.Where(x => x.IsActive).OrderBy(o => o.ID);
        }
    }
}
