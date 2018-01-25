namespace SWLOR.Web.Data.Entities
{
    public partial class PCCustomEffects
    {
        public long PccustomEffectId { get; set; }
        public string PlayerId { get; set; }
        public long CustomEffectId { get; set; }
        public int Ticks { get; set; }

        public CustomEffects CustomEffect { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
