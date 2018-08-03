using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        private Queue<Claim> queue = new Queue<Claim>();

        public void AddToQueue(Claim claim)
        {
            queue.Enqueue(claim);
        }

        public void RemoveFromQueue()
        {
            Claim claim = queue.Dequeue();
        }

        public Claim LookAtNextItem()
        {
            return queue.Peek();
        }

        public Queue<Claim> GetQueue()
        {
            return queue;
        }
    }
}
