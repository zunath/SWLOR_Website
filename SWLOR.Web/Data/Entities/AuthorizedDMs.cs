namespace SWLOR.Web.Data.Entities
{
    public partial class AuthorizedDMs
    {
        public int AuthorizedDmid { get; set; }
        public string Name { get; set; }
        public string Cdkey { get; set; }
        public int Dmrole { get; set; }
        public bool IsActive { get; set; }
    }
}
