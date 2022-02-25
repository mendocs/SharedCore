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
            this.SetItensConstructor();
        }

        public virtual void SetItensConstructor()
        {           
            if (this.keyCreatedOnConstructor == Guid.Empty )
                this.keyCreatedOnConstructor = Guid.NewGuid();

            if (this.Key == Guid.Empty)
                this.Key = this.keyCreatedOnConstructor;

            if (this.Created == DateTime.MinValue ) 
                this.Created = DateTime.Now;

            if (this.Updated == DateTime.MinValue ) 
                this.Updated = DateTime.Now;                
        }

        public void SetKey(Guid _key)
        {
            this.Key = _key;
        }

        public void SetKeyNull()
        {
            this.Key = Guid.Empty;
        }


        public void SetUpdate()
        {
            this.Updated = DateTime.Now;
        }

        public virtual bool Validate()
        {
            return true;
        }

        public virtual bool isFromDatabase()
        {
            return this.keyCreatedOnConstructor != this.Key;
        }


    }

    

}