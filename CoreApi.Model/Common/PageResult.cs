using System.Collections.Generic;

namespace CoreApi.Model.Common
{
    public class PageResult<T>
    {
        public PageResult()
        {
            Items = new List<T>();
        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public long TotalCount { get; set; }

        public IReadOnlyCollection<T> Items { get; set; }
    }
}
