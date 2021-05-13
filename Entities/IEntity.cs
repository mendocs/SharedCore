using System;

namespace SharedCore.Entities
{
    public interface IEntity
    {
         Guid Key { get; }

        DateTime Created { get; }

        DateTime Updated { get; }

        bool Validade();

        bool isFromDatabase();

        void SetUpdate();
    }
}