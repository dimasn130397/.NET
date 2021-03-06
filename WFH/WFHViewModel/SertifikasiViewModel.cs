﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WFHViewModel
{
    public class SertifikasiViewModel
    {
        public long id { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Nama Sertifikasi harus diisi")]
        [Display(Name = "Nama Sertifikasi*")]
        public string certificate_name { get; set; }
        [Required(ErrorMessage = "Penerbit harus diisi")]
        [Display(Name = "Penerbit*")]

        [StringLength(100)]

        public string publisher { get; set; }
        public bool? is_delete { get; set; }

        [Display(Name = "  ")]
        [StringLength(10)]
        public string valid_start_year { get; set; }

        [Display(Name = "Berlaku Mulai")]
        [StringLength(10)]
        public string valid_start_month { get; set; }
        [Display(Name = "  ")]
        [StringLength(10)]
        [Remote("IsBerlakuYearValid", "Sertifikasi", AdditionalFields = "until_month,valid_start_month,valid_start_year ", ErrorMessage = "Berlaku sampai tidak boleh kurang dari berlaku mulai")]
        public string until_year { get; set; }

        [Display(Name = "Berlaku Sampai")]
        [StringLength(10)]

        public string until_month { get; set; }
        [Display(Name = "Catatan")]
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string notes { get; set; }
        public long biodata_id { get; set; }
        public long user_id { get; set; }
        public long created_by { get; set; }
        public DateTime created_on { get; set; }


    }
}
