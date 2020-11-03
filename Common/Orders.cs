using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CommonTypes
{
    [DataContract]
    public class Orders : IOrders
    {
        [DataMember]
        private List<IOrder> m_orders;

        public Orders()
        {
            m_orders = new List<IOrder>();
        }

        public IOrder this[int i]
        {
            get
            {
                IOrder result = null;
                if ((i < m_orders.Count) && (i >= 0))
                {
                    result = m_orders[i];
                }
                return result;
            }

            set
            {
                if ((i < m_orders.Count) && (i >= 0))
                {
                    m_orders[i] = value;
                }
            }
        }

        public void Add(IOrder order)
        {
            m_orders.Add(order);
        }

        public void Delete(Int64 id)
        {
            for(int i=m_orders.Count-1; i >=0; i--)
            {
                if (m_orders[i].Id == id)
                {
                    m_orders.Remove(m_orders[i]);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_orders.GetEnumerator();
        }
    }
}
