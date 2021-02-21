using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookDesktopInterface
{
    public interface IAlbumAggregate
    {
        IAlbumIterator CreateIterator(int i_Index);
    }
}
