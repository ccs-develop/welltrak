using System;
namespace welltrak
{
    public abstract class Entity
    {
        public Guid ID { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset LastModifiedDate { get; set;}
    }
}
