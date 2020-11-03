namespace GService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? IdInventory { get; set; }

        public long? IdCustomer { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public DateTime? DateEvent { get; set; }
    }
}
