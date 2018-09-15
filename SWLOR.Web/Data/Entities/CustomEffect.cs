namespace SWLOR.Web.Data.Entities
{
    public class CustomEffect
    {
        public long CustomEffectID { get; set; }
        public string Name { get; set; }
        public int IconID { get; set; }
        public string ScriptHandler { get; set; }
        public string StartMessage { get; set; }
        public string ContinueMessage { get; set; }
        public string WornOffMessage { get; set; }
    }
}
