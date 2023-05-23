namespace DependencyInjectionLifeTime.Models
{
    public interface IGuidGenerator
    {
        Guid Guid { get; }
    }

    public interface ISingletonGuid : IGuidGenerator 
    {
    
    }
    public interface ITransientGuid : IGuidGenerator
    {

    }
    public interface IScopedGuid : IGuidGenerator
    {

    }
    public class Singleton : ISingletonGuid
    {
        public Guid Guid { get; private set; }
        public Singleton()
        {
            Guid = Guid.NewGuid();
        }
    }
    public class Transient : ITransientGuid
    {
        public Guid Guid { get; private set; }

        public Transient()
        {
            Guid = Guid.NewGuid();
        }
    }
    public class Scoped : IScopedGuid
    {
        public Guid Guid { get; private set; }
        public Scoped()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class GuidService 
    {
        public ISingletonGuid singleton { get; set; }
        public IScopedGuid scoped { get; set; }
        public ITransientGuid transient { get; set; }

        public GuidService(ISingletonGuid singleton, IScopedGuid scoped, ITransientGuid transient)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
        }
    }
}
