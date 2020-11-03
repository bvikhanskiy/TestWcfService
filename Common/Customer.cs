using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
    [DataContract]
    [Table("Customer")]
    public class Customer : ICustomer
    {
        private Int64 m_id;
        private String m_name;
        private bool? m_vip;

        public Customer()
        {
            m_id = 0;
            m_name = String.Empty;
            m_vip = false;
        }

        public Customer(Int64 id, String name, bool vip)
        {
            m_id = id;
            m_name = name;
            m_vip = vip;
        }

        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        [DataMember]
        [StringLength(100)]
        public String Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        [DataMember]
        public bool? Vip
        {
            get { return m_vip; }
            set { m_vip = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
