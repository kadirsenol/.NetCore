namespace Entity_Layer.Entities.Abstarct
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public int? Code { get; set; }
    }
}
