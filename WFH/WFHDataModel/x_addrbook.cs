namespace WFHDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class x_addrbook
    {
        public long id { get; set; }

        public long created_by { get; set; }

        public DateTime created_on { get; set; }

        public long? modified_by { get; set; }

        public DateTime? modified_on { get; set; }

        public long? deleted_by { get; set; }

        public DateTime? deleted_on { get; set; }

        public bool is_deleted { get; set; }

        public bool is_locked { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string abuid { get; set; }

        [Required]
        [StringLength(50)]
        public string abpwd { get; set; }
    }
}
