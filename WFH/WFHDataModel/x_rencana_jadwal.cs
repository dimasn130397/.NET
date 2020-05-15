namespace WFHDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class x_rencana_jadwal
    {
        public long id { get; set; }

        public long create_by { get; set; }

        public DateTime create_on { get; set; }

        public long? modified_by { get; set; }

        public DateTime? modified_on { get; set; }

        public long? delete_by { get; set; }

        public DateTime? delete_on { get; set; }

        public bool is_delete { get; set; }

        [StringLength(20)]
        public string schedule_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? schedule_date { get; set; }

        [StringLength(10)]
        public string time { get; set; }

        public long? ro { get; set; }

        public long? tro { get; set; }

        public long? scedule_type_id { get; set; }

        [StringLength(100)]
        public string location { get; set; }

        [StringLength(100)]
        public string other_ro_tro { get; set; }

        [StringLength(1000)]
        public string notes { get; set; }

        public bool? is_automatic_mail { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sent_date { get; set; }

        [StringLength(50)]
        public string status { get; set; }
    }
}
