namespace Table_Per_Hierarchy__TPH__for_Entity_Framework
{
    public enum RacingClass : byte
    {
        cc125 = 1,
        cc250 = 2,
        cc500 = 3
    }
    public class Motorcycle : Vehicle
    {
        public RacingClass RacingClass { get; set; }
    }
}
