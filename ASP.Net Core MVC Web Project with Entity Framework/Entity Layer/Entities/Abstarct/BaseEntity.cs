namespace Entity_Layer.Entities.Abstarct
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
        public int? Code { get; set; }
    }
}
