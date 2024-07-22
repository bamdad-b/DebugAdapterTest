namespace TGSNG.Shared.SearchModels
{
    public class CommonSearchModel
    {
        public IEnumerable<int>? TankIds { get; set; }
        public DateTime? DateTimeFrom { get; set; }
        public DateTime? DateTimeTo { get; set; }
    }
}
