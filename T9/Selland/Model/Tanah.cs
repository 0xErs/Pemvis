using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selland.Model
{
    public class Tanah
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Status { get; set; }
        public double Luas { get; set; }
        public string Alamat { get; set; }
        public decimal Harga { get; set; }
        public int UserId { get; set; }
    }
}
