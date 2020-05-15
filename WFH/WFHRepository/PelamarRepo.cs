
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFHDataModel;
using WFHViewModel;

namespace WFHRepository
{
    public class PelamarRepo
    {

        public static BiodataViewModel ById(long id)
        {

            //id category.Id
            BiodataViewModel result = new BiodataViewModel();
            using (var db = new WFHContext())
            {

                result = (from v in db.x_address
                          join c in db.x_biodata
                          on v.biodata_id equals c.id
                          where v.biodata_id == id
                          select new BiodataViewModel
                          {
                              id = v.id,
                              biodata_id = v.biodata_id,
                              fullname = c.fullname,
                              nick_name = c.nick_name,
                              pob = c.pob,
                              dob = c.dob,
                              gender = c.gender,

                              religion_id = c.religion_id,
                              high = c.high,
                              weight = c.weight,
                              nationality = c.nationality,
                              ethnic = c.ethnic,
                              hobby = c.hobby,
                              identity_type_id = c.identity_type_id,
                              identity_no = c.identity_no,
                              email = c.email,
                              phone_number1 = c.phone_number1,
                              phone_number2 = c.phone_number2,
                              parent_phone_number = c.parent_phone_number,
                              child_sequence = c.child_sequence,
                              how_many_brothers = c.how_many_brothers,
                              marital_status_id = c.marital_status_id,
                              marriage_year = c.marriage_year,
                              company_id = c.company_id,

                              address1 = v.address1,
                              postal_code1 = v.postal_code1,
                              rt1 = v.rt1,
                              rw1 = v.rw1,
                              kelurahan1 = v.kelurahan1,
                              kecamatan1 = v.kecamatan1,
                              region1 = v.region1,
                              address2 = v.address2,
                              postal_code2 = v.postal_code2,
                              rt2 = v.rt2,
                              rw2 = v.rw2,
                              kelurahan2 = v.kelurahan2,
                              kecamatan2 = v.kecamatan2,
                              region2 = v.region2


                          }).FirstOrDefault();


                

            }

            return result;

        }

        public static List<PelamarViewModel> GetBySearch(string search, int desc, int page, int dataPerPage)
        {
            List<PelamarViewModel> result = new List<PelamarViewModel>();
            using (var db = new WFHContext())
            {
                if (desc == 1)
                {
                    //result = db.x_biodata.
                    //Join(db.x_riwayat_pendidikan, u => u.id, uir => uir.biodata_id,
                    //(u, uir) => new { u, uir })
                    //.Where(v => v.u.is_deleted == false && (v.u.fullname.Contains(search)
                    //|| v.u.nick_name.Contains(search)))
                    //.OrderByDescending(v => v.u.fullname)
                    //.Skip(page * dataPerPage)
                    //.Take(dataPerPage)
                    //.Select(v => new PelamarViewModel
                    //{
                    //    id = v.u.id,
                    //    fullname = v.u.fullname,
                    //    nick_name = v.u.nick_name,
                    //    email = v.u.email,
                    //    phone_number1 = v.u.phone_number1,
                    //    pendidikan = v.uir.school_name,
                    //    jurusan = v.uir.major

                    //}).ToList();
                    result = db.x_biodata
                        .Where(b => b.is_deleted == false && (b.fullname.Contains(search)
                    || b.nick_name.Contains(search)))
                    .OrderByDescending(b => b.fullname)
                    .Skip(page * dataPerPage)
                    .Take(dataPerPage)
                    .Select(b => new PelamarViewModel
                    {
                        id = b.id,
                        fullname = b.fullname,
                        nick_name = b.nick_name,
                        email = b.email,
                        phone_number1 = b.phone_number1,
                        pendidikan = db.x_riwayat_pendidikan.Where(rp => rp.biodata_id == b.id)
                        .OrderByDescending(rp => rp.graduation_year)
                        .Select(rp => rp.school_name)
                        .FirstOrDefault(),
                        jurusan = db.x_riwayat_pendidikan.Where(rp => rp.biodata_id == b.id)
                        .OrderByDescending(rp => rp.graduation_year)
                        .Select(rp => rp.major)
                        .FirstOrDefault(),

                    }).ToList();
                }
                else
                {
                    //result = db.x_biodata.
                    //Join(db.x_riwayat_pendidikan, u => u.id, uir => uir.biodata_id,
                    //(u, uir) => new { u, uir })
                    //.Where(v => v.u.is_deleted == false && (v.u.fullname.Contains(search)
                    //|| v.u.nick_name.Contains(search)))
                    //.OrderBy(v => v.u.fullname)
                    //.Skip(page * dataPerPage)
                    //.Take(dataPerPage)
                    //.Select(v => new PelamarViewModel
                    //{
                    //    id = v.u.id,
                    //    fullname = v.u.fullname,
                    //    nick_name = v.u.nick_name,
                    //    email = v.u.email,
                    //    phone_number1 = v.u.phone_number1,
                    //    pendidikan = v.uir.school_name,
                    //    jurusan = v.uir.major

                    //}).ToList();
                    result = db.x_biodata
                        .Where(b => b.is_deleted == false && (b.fullname.Contains(search)
                    || b.nick_name.Contains(search)))
                    .OrderBy(b => b.fullname)
                    .Skip(page * dataPerPage)
                    .Take(dataPerPage)
                    .Select(b => new PelamarViewModel
                    {
                        id = b.id,
                        fullname = b.fullname,
                        nick_name = b.nick_name,
                        email = b.email,
                        phone_number1 = b.phone_number1,
                        pendidikan = db.x_riwayat_pendidikan.Where(rp => rp.biodata_id == b.id)
                        .OrderByDescending(rp => rp.graduation_year)
                        .Select(rp => rp.school_name)
                        .FirstOrDefault(),
                        jurusan = db.x_riwayat_pendidikan.Where(rp => rp.biodata_id == b.id)
                        .OrderByDescending(rp => rp.graduation_year)
                        .Select(rp => rp.major)
                        .FirstOrDefault(),

                    }).ToList();
                }

            }

            return result != null ? result : new List<PelamarViewModel>();
        }
    }
}
