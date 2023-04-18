using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace modul9_1302210055.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("M. Yaasin Rafi", "1302210055", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2021),
            new Mahasiswa("Walid Hanif Ataullah", "1302213120", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2021),
            new Mahasiswa("Muhammad Raffa Zuhayr", "1302210068", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2021),
            new Mahasiswa("Sylvana Rheina Khrameliawaty", "1302210017", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2021),
            new Mahasiswa("Nabiel P", "1302210049", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2021)


        };


        // GET: api/<MahasiswaController>
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMhs[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost(Name = "PostMahasiswa")]
        public IActionResult Post(Mahasiswa value)
        {
            listMhs.Add(value);
            return Ok(listMhs);
        }


        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            listMhs.RemoveAt(id);
            return Ok(listMhs);
        }
    }
}