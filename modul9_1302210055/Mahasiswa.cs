namespace modul9_1302210055
{
    public class Mahasiswa
    {
        private string v1;
        private string v2;

        public string? Nama { get; set; }
        public string? Nim { get; set; }
        public List<string>? Course {  get; set; }
        public int? Year { get; set; }

        public Mahasiswa() { }
        public Mahasiswa(string Nama, string Nim, List<String>Course, int year)
        {
            this.Nama = Nama;
            this.Nim = Nim;
            this.Year = year;
            this.Course = Course;
        }

        public Mahasiswa(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
