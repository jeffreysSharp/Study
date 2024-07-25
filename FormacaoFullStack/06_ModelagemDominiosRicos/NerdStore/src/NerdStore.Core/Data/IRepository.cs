using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : DomainObjects.IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
