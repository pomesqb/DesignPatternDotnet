using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class History
    {
        private List<string> _historyData = new List<string>();

        public List<string> GetHistoryData
        {
            get => _historyData;
            set => _historyData = value;
        }

        public void Push(string item)
        {
            _historyData.Add(item);
        }

        public string Pop()
        {
            var lastItemIndex = _historyData.Count - 1;
            var result = _historyData[lastItemIndex];
            _historyData.RemoveAt(lastItemIndex);

            return result;
        }
    }
}
