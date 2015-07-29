using System;
using System.ComponentModel.DataAnnotations;

namespace Serkomut.Repository.Core
{
    public abstract class BaseEntity
    {
         [Key]
         public Guid Id { get; set; }
    }
}