using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.src.Entities;

namespace Domain.src.Entities
{
    public class BaseEntityWithId : BaseEntity
    {
        public Guid Id { get; set; }
    }
}
