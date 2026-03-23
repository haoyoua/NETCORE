using System.ComponentModel.DataAnnotations;

namespace CoreApi.Model.Common
{
    public class PageQuery
    {
        private const int MaxPageSize = 200;
        private int _pageIndex = 1;
        private int _pageSize = 20;

        [Range(1, int.MaxValue)]
        public int PageIndex
        {
            get => _pageIndex;
            set => _pageIndex = value < 1 ? 1 : value;
        }

        [Range(1, MaxPageSize)]
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value < 1 ? 20 : (value > MaxPageSize ? MaxPageSize : value);
        }

        public int SkipCount => (PageIndex - 1) * PageSize;
    }
}
