using System;

namespace CoreApi.Model.Entities
{
    public abstract class BaseAuditEntity<TKey> : BaseEntity<TKey>
    {
        public DateTime CreateTime { get; set; } = DateTime.Now;

        public DateTime? UpdateTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
