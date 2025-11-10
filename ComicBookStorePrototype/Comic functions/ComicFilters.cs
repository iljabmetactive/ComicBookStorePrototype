using ComicBookStorePrototype.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookStorePrototype.Comic_functions
{
    public class ComicFilters
    {
        public IEnumerable<Comics> FilterByGenre(IEnumerable<Comics> comics, string genre)
        {
            if (string.IsNullOrEmpty(genre) || genre == "show all")
                return comics;

            return comics.Where(c => !string.IsNullOrEmpty(c.Genre) &&
                             c.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase));

        }

        public IEnumerable<Comics> SortComics(IEnumerable<Comics> comics, string sortBy, bool descending)
        {
            return sortBy switch
            {
                "Name" => descending
                    ? comics.OrderByDescending(c => c.Name)
                    : comics.OrderBy(c => c.Name),
                "Year of Publication" => descending
                    ? comics.OrderByDescending(c => c.DateOfPublication)
                    : comics.OrderBy(c => c.DateOfPublication),
                _ => comics
            };
        }
    }
}
