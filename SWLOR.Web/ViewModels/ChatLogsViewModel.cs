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
    public class ChatLogsViewModel : PaginateBaseVM
    {
        public ChatLogsViewModel(DataContext db)
            : base(BuildClientData(db),
                nameof(ChatLog.ChatLogID))
        {

        }

        private static IEnumerable<dynamic> BuildClientData(DataContext db)
        {
            return db.ChatLog.OrderByDescending(x => x.DateSent);
        }

    }
}
