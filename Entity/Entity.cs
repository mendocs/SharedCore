using System;

namespace SharedCore.Entity
{
    public class Entity: IEntity
    {
        public Guid Key { get; set; }

        protected Entity()
        {
            this.Key = Guid.NewGuid();
        }        
    }
}