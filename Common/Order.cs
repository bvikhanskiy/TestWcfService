using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
    [DataContract]
    [Table("Order")]
    public class Order : IOrder
    {
        private Int64 m_id;
        private Int64 m_idInventory;
        private Int64 m_idCustomer;
        private String m_comment;
        private DateTime m_dateEvent;

        public Order()
        {
            m_id = 0;
            m_idInventory = 0;
            m_idCustomer = 0;
            m_comment = String.Empty;
            m_dateEvent = DateTime.MinValue;
        }

        public Order(Int64 id, Int64 idInventory, Int64 idCustomer, String comment, DateTime dateEvent)
        {
            m_id = id;
            m_idInventory = idInventory;
            m_idCustomer = idCustomer;
            m_comment = comment;
            m_dateEvent = dateEvent;
        }

        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        [DataMember]
        public Int64 IdInventory
        {
            get { return m_idInventory; }
            set { m_idInventory = value; }
        }

        [DataMember]
        public Int64 IdCustomer
        {
            get { return m_idCustomer; }
            set { m_idCustomer = value; }
        }

        [DataMember]
        [StringLength(100)]
        public String Comment
        {
            get { return m_comment; }
            set { m_comment = value; }
        }

        [DataMember]
        public DateTime DateEvent
        {
            get { return m_dateEvent; }
            set { m_dateEvent = value; }
        }

    }
}
