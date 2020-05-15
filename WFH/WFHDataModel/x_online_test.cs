namespace WFHDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class x_online_test
    {
        public long id { get; set; }

        public long created_by { get; set; }

        public DateTime created_on { get; set; }

        public long? modified_by { get; set; }

        public DateTime? modified_on { get; set; }

        public long? deleted_by { get; set; }

        public DateTime? deleted_on { get; set; }

        public bool is_delete { get; set; }

        public long? biodata_id { get; set; }

        [StringLength(500)]
        public string period_code { get; set; }

        public int? period { get; set; }

        [Column(TypeName = "date")]
        public DateTime? test_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expired_test { get; set; }

        [StringLength(10)]
        public string user_access { get; set; }

        [StringLength(50)]
        public string status { get; set; }
    }
}
