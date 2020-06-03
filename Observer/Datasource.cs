using System;
using System.Collections.Generic;

namespace Observer
{
    class Datasource
    {
        public string SubjectState { get; set; }

        private List<Observer> _listNotify = new List<Observer>();

        public void ChangeData()
        {
            Console.WriteLine("ChangeData");
            Notify();
        }

        public void Attach(Observer notify)
        {
            _listNotify.Add(notify);
        }

        public void Detach(Observer notify)
        {
            _listNotify.Remove(notify);
        }

        public void Notify()
        {
            foreach (var item in _listNotify)
            {
                item.Update();
            }
        }
    }
}
