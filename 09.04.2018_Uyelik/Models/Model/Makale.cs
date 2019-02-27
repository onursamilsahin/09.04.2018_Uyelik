using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09._04._2018_Uyelik.Models.Model
{
    public class Makale
    {
        public int MakaleId { get; set; }

        public string Baslik { get; set; }

        public string Aciklama { get; set; }

        public DateTime EklenmeTarihi { get; set; }

        public int YorumID { get; set; }
        //Bir makalede, birden çok yorum bulunabilir.
        public virtual List<Yorum> Yorums { get; set; }


    }
}