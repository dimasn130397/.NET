namespace WFHDataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WFHContext : DbContext
    {
        public WFHContext()
            : base("name=WFHContext")
        {
        }

        public virtual DbSet<x_addrbook> x_addrbook { get; set; }
        public virtual DbSet<x_address> x_address { get; set; }
        public virtual DbSet<x_biodata> x_biodata { get; set; }
        public virtual DbSet<x_biodata_attachment> x_biodata_attachment { get; set; }
        public virtual DbSet<x_catatan> x_catatan { get; set; }
        public virtual DbSet<x_company> x_company { get; set; }
        public virtual DbSet<x_education_level> x_education_level { get; set; }
        public virtual DbSet<x_family_relation> x_family_relation { get; set; }
        public virtual DbSet<x_family_tree_type> x_family_tree_type { get; set; }
        public virtual DbSet<x_identity_type> x_identity_type { get; set; }
        public virtual DbSet<x_keahlian> x_keahlian { get; set; }
        public virtual DbSet<x_keluarga> x_keluarga { get; set; }
        public virtual DbSet<x_keterangan_tambahan> x_keterangan_tambahan { get; set; }
        public virtual DbSet<x_marital_status> x_marital_status { get; set; }
        public virtual DbSet<x_menu_acces> x_menu_acces { get; set; }
        public virtual DbSet<x_menutree> x_menutree { get; set; }
        public virtual DbSet<x_note_yype> x_note_yype { get; set; }
        public virtual DbSet<x_online_rest_detail> x_online_rest_detail { get; set; }
        public virtual DbSet<x_online_test> x_online_test { get; set; }
        public virtual DbSet<x_organisasi> x_organisasi { get; set; }
        public virtual DbSet<x_pe_referensi> x_pe_referensi { get; set; }
        public virtual DbSet<x_religion> x_religion { get; set; }
        public virtual DbSet<x_rencana_jadwal> x_rencana_jadwal { get; set; }
        public virtual DbSet<x_rencana_jadwal_detail> x_rencana_jadwal_detail { get; set; }
        public virtual DbSet<x_riwayat_pekerjaan> x_riwayat_pekerjaan { get; set; }
        public virtual DbSet<x_riwayat_pelatihan> x_riwayat_pelatihan { get; set; }
        public virtual DbSet<x_riwayat_pendidikan> x_riwayat_pendidikan { get; set; }
        public virtual DbSet<x_riwayat_proyek> x_riwayat_proyek { get; set; }
        public virtual DbSet<x_role> x_role { get; set; }
        public virtual DbSet<x_schedule_type> x_schedule_type { get; set; }
        public virtual DbSet<x_sertifikasi> x_sertifikasi { get; set; }
        public virtual DbSet<x_skill_level> x_skill_level { get; set; }
        public virtual DbSet<x_sumber_loker> x_sumber_loker { get; set; }
        public virtual DbSet<x_test_type> x_test_type { get; set; }
        public virtual DbSet<x_time_period> x_time_period { get; set; }
        public virtual DbSet<x_undangan> x_undangan { get; set; }
        public virtual DbSet<x_undangan_detail> x_undangan_detail { get; set; }
        public virtual DbSet<x_userrole> x_userrole { get; set; }
        public virtual DbSet<x_vacancy_source> x_vacancy_source { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<x_addrbook>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<x_addrbook>()
                .Property(e => e.abuid)
                .IsUnicode(false);

            modelBuilder.Entity<x_addrbook>()
                .Property(e => e.abpwd)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.postal_code1)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.rt1)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.rw1)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.kelurahan1)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.kecamatan1)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.region1)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.postal_code2)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.rt2)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.rw2)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.kelurahan2)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.kecamatan2)
                .IsUnicode(false);

            modelBuilder.Entity<x_address>()
                .Property(e => e.region2)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.nick_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.pob)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.nationality)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.ethnic)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.hobby)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.identity_no)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.phone_number1)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.phone_number2)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.parent_phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.child_sequence)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.how_many_brothers)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.token)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata>()
                .Property(e => e.marriage_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata_attachment>()
                .Property(e => e.file_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata_attachment>()
                .Property(e => e.file_path)
                .IsUnicode(false);

            modelBuilder.Entity<x_biodata_attachment>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_catatan>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<x_catatan>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_company>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_company>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_education_level>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_education_level>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_family_relation>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_family_relation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_family_tree_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_family_tree_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_identity_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_identity_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_keahlian>()
                .Property(e => e.skill_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_keahlian>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_keluarga>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_keluarga>()
                .Property(e => e.job)
                .IsUnicode(false);

            modelBuilder.Entity<x_keluarga>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.emergency_contact_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.emergency_contact_phone)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.expected_salary)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.start_working)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.apply_place)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.selection_phase)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.disease_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.disease_time)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.psychotest_needs)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.psychotest_time)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.requirementes_required)
                .IsUnicode(false);

            modelBuilder.Entity<x_keterangan_tambahan>()
                .Property(e => e.other_notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_marital_status>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_marital_status>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_menutree>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<x_menutree>()
                .Property(e => e.menu_image_url)
                .IsUnicode(false);

            modelBuilder.Entity<x_menutree>()
                .Property(e => e.menu_icon)
                .IsUnicode(false);

            modelBuilder.Entity<x_menutree>()
                .Property(e => e.menu_url)
                .IsUnicode(false);

            modelBuilder.Entity<x_menutree>()
                .Property(e => e.menu_type)
                .IsUnicode(false);

            modelBuilder.Entity<x_note_yype>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_note_yype>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_online_test>()
                .Property(e => e.period_code)
                .IsUnicode(false);

            modelBuilder.Entity<x_online_test>()
                .Property(e => e.user_access)
                .IsUnicode(false);

            modelBuilder.Entity<x_online_test>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.entry_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.exit_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.responsibility)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_pe_referensi>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_pe_referensi>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<x_pe_referensi>()
                .Property(e => e.address_phone)
                .IsUnicode(false);

            modelBuilder.Entity<x_pe_referensi>()
                .Property(e => e.relation)
                .IsUnicode(false);

            modelBuilder.Entity<x_religion>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_religion>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_rencana_jadwal>()
                .Property(e => e.schedule_code)
                .IsUnicode(false);

            modelBuilder.Entity<x_rencana_jadwal>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<x_rencana_jadwal>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<x_rencana_jadwal>()
                .Property(e => e.other_ro_tro)
                .IsUnicode(false);

            modelBuilder.Entity<x_rencana_jadwal>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_rencana_jadwal>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.company_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.join_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.join_month)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.resign_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.resign_month)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.last_position)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.income)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.about_job)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.exit_reason)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pekerjaan>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pelatihan>()
                .Property(e => e.training_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pelatihan>()
                .Property(e => e.organizer)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pelatihan>()
                .Property(e => e.training_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pelatihan>()
                .Property(e => e.training_month)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pelatihan>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pelatihan>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pelatihan>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.school_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.entry_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.graduation_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.major)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.judul_ta)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.deskripsi_ta)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_proyek>()
                .Property(e => e.start_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_proyek>()
                .Property(e => e.start_month)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_proyek>()
                .Property(e => e.poject_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_proyek>()
                .Property(e => e.client)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_proyek>()
                .Property(e => e.project_position)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_proyek>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_role>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<x_role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_schedule_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_schedule_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_sertifikasi>()
                .Property(e => e.certificate_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_sertifikasi>()
                .Property(e => e.publisher)
                .IsUnicode(false);

            modelBuilder.Entity<x_sertifikasi>()
                .Property(e => e.valid_start_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_sertifikasi>()
                .Property(e => e.valid_start_month)
                .IsUnicode(false);

            modelBuilder.Entity<x_sertifikasi>()
                .Property(e => e.until_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_sertifikasi>()
                .Property(e => e.until_month)
                .IsUnicode(false);

            modelBuilder.Entity<x_sertifikasi>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_skill_level>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_skill_level>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.vacancy_source)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.candidate_type)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.event_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.career_center_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.referrer_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.referrer_phone)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.referrer_email)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.other_source)
                .IsUnicode(false);

            modelBuilder.Entity<x_sumber_loker>()
                .Property(e => e.last_income)
                .IsUnicode(false);

            modelBuilder.Entity<x_test_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_test_type>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_time_period>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_time_period>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<x_undangan>()
                .Property(e => e.invitation_code)
                .IsUnicode(false);

            modelBuilder.Entity<x_undangan>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<x_undangan>()
                .Property(e => e.other_ro_tro)
                .IsUnicode(false);

            modelBuilder.Entity<x_undangan>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<x_undangan>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<x_undangan_detail>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_vacancy_source>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_vacancy_source>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
