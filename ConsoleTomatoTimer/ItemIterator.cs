using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTomatoTimer
{
    class ItemIterator
    {
        string[] _items;
        int _current = -1;
        public ItemIterator(string[] items)
        {
            _items = items;
        }

        public bool MoveNext()
        {
            ++_current;
            return _items.Length > _current;
        }

        public string Value
        {
            get
            {
                return _items[_current];
            }
        }
    }
}
