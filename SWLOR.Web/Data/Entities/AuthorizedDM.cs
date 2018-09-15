namespace SWLOR.Web.Data.Entities
{
    public partial class AuthorizedDM
    {
        public int AuthorizedDMID { get; set; }
        public string Name { get; set; }
        public string CDKey { get; set; }
        public int DMRole { get; set; }
        public bool IsActive { get; set; }
    }
}
