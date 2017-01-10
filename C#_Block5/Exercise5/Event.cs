using System.Collections;
using System.Collections.Generic;

namespace Exercise5
{
    public class Event : IEnumerable<Participant>
    {
        private IList<Participant> participiantList;

        public Event()
        {
            participiantList = new List<Participant>();
        }

        public void AddParticipant(Participant partec)
        {
            participiantList.Add(partec);
        }
        
        public void Remove(Participant partec)
        {
            this.participiantList.Remove(partec);
        }

        public void Clear()
        {
            participiantList.Clear();
        }

        public IEnumerator<Participant> GetEnumerator()
        {
            foreach (Participant partic in participiantList)
            {
                yield return partic;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
