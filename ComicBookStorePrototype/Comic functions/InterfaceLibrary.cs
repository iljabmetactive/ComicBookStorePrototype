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

    public interface IComicLoad
    {
        List<Comics> LoadData();
    }
    public class InterfaceLibrary
    {
    }
}
