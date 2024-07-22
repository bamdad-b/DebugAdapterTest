#nullable disable
namespace TGSNG.Domain.Entities
{
    public class Tank
    {
        public int Id { get; set; }
        public string Name { get; set; }


        #region AdditionalColumns
        public string BackgroundColor { get; set; }
        public string Initials { get; set; }
        #endregion


        public string Tag { get; set; }
        public int ShapeID { get; set; }
        public string NominalCapacityM3 { get; set; }
        public string NominalCapacityBarrel { get; set; }
        public string NominalHeight { get; set; }
        public string OperatingCapacity { get; set; }
        public string OperatingHeight { get; set; }
        public string MaxOperatingHeight { get; set; }
        public string MinOperatingHeight { get; set; }
        public string CriticalOperatingHeight { get; set; }
        public string SiphonHeight { get; set; }
        public int MaterialTypeID { get; set; }
        public string Area { get; set; }
        public string CompareTime { get; set; }
        public string CompareDamp { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
        public float Gravity { get; set; }
        public int ZoneId { get; set; }
        public int GravityModifiedBy { get; set; }
        public DateTime GravityModifiedTime { get; set; }
        public int TankType { get; set; }
        public string Priority { get; set; }
    }
}
