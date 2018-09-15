using System.Collections.Generic;
using System.Linq;
using SWLOR.Web.Attributes;
using SWLOR.Web.Constants;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;
using SWLOR.Web.ViewModels.BaseViewModels;

namespace SWLOR.Web.ViewModels
{
    [RoleRequired(RoleType.Admin, RoleType.DM)]
    public class ConnectionLogsViewModel : PaginateBaseVM
    {
        public ConnectionLogsViewModel(DataContext db)
            : base(BuildClientData(db),
                nameof(ClientLogEvent.ClientLogEventID))
        {
        }

        private static IEnumerable<dynamic> BuildClientData(DataContext db)
        {
            return db.ClientLogEvents.OrderByDescending(o => o.DateOfEvent);
        }
    }
}
