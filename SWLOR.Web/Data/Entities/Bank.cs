using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Bank
    {
        public Bank()
        {
            BankItem = new HashSet<BankItem>();
        }

        public int ID { get; set; }
        public string AreaName { get; set; }
        public string AreaTag { get; set; }
        public string AreaResref { get; set; }

        public ICollection<BankItem> BankItem { get; set; }
    }
}
