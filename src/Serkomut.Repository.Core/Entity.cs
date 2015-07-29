using System;
using System.ComponentModel.DataAnnotations;

namespace Serkomut.Repository.Core
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public T Id { get; set; }
    }
}