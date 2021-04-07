using System;

namespace SharedCore.Entities
{
    public abstract class Entity:   IEntity
    {
        public Guid Key { get; private set; }
        public  DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        private Guid keyCreatedOnConstructor;

        

        protected Entity()
        {
            this.Key = Guid.NewGuid();
            this.keyCreatedOnConstructor = this.Key;
            this.Updated = DateTime.Now;
            this.Created = DateTime.Now;
        }        

        public virtual bool Validade()
        {
            return true;
        }

        public virtual bool isFromDatabase()
        {
            return this.keyCreatedOnConstructor != this.Key;
        }


    }

    

}