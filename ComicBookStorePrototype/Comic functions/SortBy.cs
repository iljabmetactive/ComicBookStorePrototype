using ComicBookStorePrototype.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookStorePrototype.Comic_functions
{
    public interface IComicSortBy
    {
        IEnumerable<Comics> SortAssendOrDescend(IEnumerable<Comics> comics, bool descending);
    }

    public class SortByName : IComicSortBy
    {
        public IEnumerable<Comics> SortAssendOrDescend(IEnumerable<Comics> comics, bool descending) =>
            descending
                ? comics.OrderByDescending(c => c.Name)
                : comics.OrderBy(c => c.Name);
    }

    public class SortByYearOfPublication : IComicSortBy
    {
        public IEnumerable<Comics> SortAssendOrDescend(IEnumerable<Comics> comics, bool descending) =>
            descending
                ? comics.OrderByDescending(c => c.DateOfPublication)
                : comics.OrderBy(c => c.DateOfPublication);
    }

    public class SortBy
    {
        private readonly Dictionary<string, IComicSortBy> _sortStrategies = new()
        {
            { "Name", new SortByName() },
            { "Year of Publication", new SortByYearOfPublication() },
        };

        public IComicSortBy GetStrategy(string sortBy) =>
            _sortStrategies.ContainsKey(sortBy) ? _sortStrategies[sortBy]
                :   new SortByName();
    }
}
