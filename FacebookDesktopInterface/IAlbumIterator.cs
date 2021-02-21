using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookDesktopInterface
{
    public interface IAlbumIterator
    {
        bool MoveNext();

        bool MovePrev();

        object Current { get; }

        void Reset();
    }
}
