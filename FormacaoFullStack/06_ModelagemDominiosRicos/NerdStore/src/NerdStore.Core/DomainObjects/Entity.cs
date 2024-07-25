using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }


        public override bool Equals(object obj)
        {
            var compareTool = obj as Entity;

            if (ReferenceEquals(this, compareTool)) return true;
            if (ReferenceEquals(null, compareTool)) return false;

            return Id.Equals(compareTool.Id);

        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode(); 
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }
    }
}
