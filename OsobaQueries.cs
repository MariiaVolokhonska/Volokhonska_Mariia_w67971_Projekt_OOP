using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_OOP
{
    public class OsobaQueries
    {
        public int OsobaID { get; set; }
        public string NazwiskoAktualne { get; set; }
        public string NazwiskoPoprzednie { get; set; }
        public string ImieAktualne { get; set; }
        public string ImiePoprzdnie { get; set; }
        public string NazwiskoRodoweMatki { get; set; }
        public string DataUrodzenia { get; set; }
        public string MiejsceUrodzenia { get; set; }
        public string Narodowość { get; set; }
        public string Obywatelstwo { get; set; }
        public string Płeć { get; set; }
        public string RodzajDokumentuTorzsamości { get; set; }
        public string NumerDokumentuTorzsamości { get; set; }
        public string Wykształcenie { get; set; }
        public string Zawód { get; set; }
        public string KategoriaID { get; set; }
        public string FormularzID { get; set; }
        public string NumerPESEL { get; set; }
        public string Adres { get; set; }
        public string NumerTelefonu { get; set; }

        public OsobaQueries(int osobaID, string nazwiskoAktualne, string nazwiskoPoprzednie, string imieAktualne, string imiePoprzdnie, string nazwiskoRodoweMatki, string dataUrodzenia, string miejsceUrodzenia, string narodowość, string obywatelstwo, string płeć, string rodzajDokumentuTorzsamości, string numerDokumentuTorzsamości, string wykształcenie, string zawód, string kategoriaID, string formularzID, string numerPESEL, string adres, string numerTelefonu)
        {
            OsobaID = osobaID;
            NazwiskoAktualne = nazwiskoAktualne;
            NazwiskoPoprzednie = nazwiskoPoprzednie;
            ImieAktualne = imieAktualne;
            ImiePoprzdnie = imiePoprzdnie;
            NazwiskoRodoweMatki = nazwiskoRodoweMatki;
            DataUrodzenia = dataUrodzenia;
            MiejsceUrodzenia = miejsceUrodzenia;
            Narodowość = narodowość;
            Obywatelstwo = obywatelstwo;
            Płeć = płeć;
            RodzajDokumentuTorzsamości = rodzajDokumentuTorzsamości;
            NumerDokumentuTorzsamości = numerDokumentuTorzsamości;
            Wykształcenie = wykształcenie;
            Zawód = zawód;
            KategoriaID = kategoriaID;
            FormularzID = formularzID;
            NumerPESEL = numerPESEL;
            Adres = adres;
            NumerTelefonu = numerTelefonu;
        }
      
    }
}
