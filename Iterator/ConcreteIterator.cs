using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class ConcreteIterator : IIterator
    {
        private int _index;

        private History _history;

        public ConcreteIterator(History history)
        {
            _history = history;
        }

        public object CurrentItem()
        {
            return _history.GetHistoryData[_index];
        }

        public object First()
        {
            return _history.GetHistoryData[0];
        }

        public bool IsDone()
        {
            return _index >= _history.GetHistoryData.Count;
        }

        public void Next()
        {
            _index++;
        }
    }
}
