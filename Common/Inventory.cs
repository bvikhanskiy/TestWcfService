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
    [Table("Inventory")]
    [DataContract]
    public class Inventory : IInventory
    {
        private Int64 m_id;
        private String m_name;
        private double? m_price;

        public Inventory()
        {
            m_id = 0;
            m_name = String.Empty;
            m_price = 0f;
        }

        public Inventory(Int64 id, String name, float price)
        {
            m_id = id;
            m_name = name;
            m_price = price;
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
        public double? Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
