using System;

namespace SharedCore.Entity
{
    public interface IEntity
    {
         Guid Key { get; set; }
    }
}