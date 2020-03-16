namespace Abc.Data.Common
{
    public abstract class NamedEntityData:UniqueEntityData
    {
        public string Name { get; set; }
        public string Code { get; set; }
        
    }
}
