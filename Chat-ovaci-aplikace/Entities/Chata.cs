using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Chata")]
    public class Chata
    {
        [Key]
        public int IdChaty { get; set; }
        public string Jmeno { get; set; }
        public DateTime Zacatek { get; set; }
        public DateTime Konec { get; set; }
        public int Kapacita { get; set; }
        public string Zeme { get; set; }
        public string Mesto { get; set; }
        public string? CastMesta { get; set; }
        public string Ulice { get; set; }
        public string PSC { get; set; }

        [JsonIgnore]
        public virtual List<Ucastnik> Ucastnici { get; set; }
        [JsonIgnore]

        public virtual List<Den> Dny { get; set; }
        [JsonIgnore]

        public virtual List<Mistnost> Mistnosti { get; set; }
        [JsonIgnore]

        public virtual List<Vlakno> Vlakna { get; set; }

        public Chata(int idChaty, string jmeno, DateTime zacatek, DateTime konec, int kapacita, List<Ucastnik> ucastnici, List<Den> dny, List<Mistnost> mistnosti, List<Vlakno> vlakna, string zeme, string mesto, string? castMesta, string ulice, string pSC)
        {
            IdChaty = idChaty;
            Jmeno = jmeno;
            Zacatek = zacatek;
            Konec = konec;
            Kapacita = kapacita;
            Ucastnici = ucastnici;
            Dny = dny;
            Mistnosti = mistnosti;
            Vlakna = vlakna;
            Zeme = zeme;
            Mesto = mesto;
            CastMesta = castMesta;
            Ulice = ulice;
            PSC = pSC;
        }
        public Chata()
        {
            IdChaty = 0;
            Jmeno = string.Empty;
            Zacatek = DateTime.Now;
            Konec = DateTime.Now;
            Kapacita = 0;
            Ucastnici = new List<Ucastnik>();
            Dny = new List<Den>();
            Mistnosti = new List<Mistnost>();
            Vlakna = new List<Vlakno>();
            Zeme = string.Empty;
            Mesto = string.Empty;
            CastMesta = string.Empty;
            Ulice = string.Empty;
            PSC = string.Empty;
        }
    }
}
