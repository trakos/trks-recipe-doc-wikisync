using System.Collections.Generic;
using TrksRecipeDoc.MekaWiki.Entities;

namespace TrksRecipeDoc.MekaWiki
{
    public sealed class PageResult<TData>
    {
        public infoResult Info { get; private set; }
        public IEnumerable<TData> Data { get; private set; }

        public PageResult(infoResult info, IEnumerable<TData> data)
        {
            Info = info;
            Data = data;
        }
    }

    public static class PageResult
    {
        public static PageResult<TData> Create<TData>(infoResult info, IEnumerable<TData> data)
        {
            return new PageResult<TData>(info, data);
        }
    }
}