using Scrumler.Entity.Base;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using System;

namespace Scrumler.Entity.ViewModels.Responses.Malzeme
{
    public class ResponseSAMalzemeTalep : ResponseBase
    {
        public int SaMalzemeTalepID { get; set; }
        public string TalepNo { get; set; }
        public DateTime TalepTarihi { get; set; }
        public int DepoID { get; set; }
        public int IsyeriID { get; set; }
        public int KullaniciID { get; set; }

        //Bu şekilde yazılırsa sadece istenen alan geliyor. ##SONKISIM
        public ResponseIsyeriJustName Isyeri { get; set; }
        //public ResponseKullanici Kullanici { get; set; }
    }
}