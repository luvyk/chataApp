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
        public decimal Cena { get; set; }
        public DateTime? Zacatek { get; set; }
        public DateTime? Konec { get; set; }
        public int Kapacita { get; set; }

        [JsonIgnore]
        public virtual ICollection<Ucastnik> Ucastnici { get; set; }
        [JsonIgnore]

        public virtual ICollection<Den> Dny { get; set; }
        [JsonIgnore]

        public virtual ICollection<Mistnost> Mistnosti { get; set; }
        [JsonIgnore]

        public virtual ICollection<Vlakno> Vlakna { get; set; }

        public Chata(int idChaty, string jmeno, decimal cena, DateTime zacatek, DateTime konec, int kapacita, ICollection<Ucastnik> ucastnici, ICollection<Den> dny, ICollection<Mistnost> mistnosti, ICollection<Vlakno> vlakna)
        {
            IdChaty = idChaty;
            Jmeno = jmeno;
            Cena = cena;
            Zacatek = zacatek;
            Konec = konec;
            Kapacita = kapacita;
            Ucastnici = ucastnici;
            Dny = dny;
            Mistnosti = mistnosti;
            Vlakna = vlakna;
        }
        public Chata()
        {
            IdChaty = 0;
            Jmeno = string.Empty;
            Cena = 0;
            Zacatek = DateTime.Now;
            Konec = DateTime.Now;
            Kapacita = 0;
            Ucastnici = new List<Ucastnik>();
            Dny = new List<Den>();
            Mistnosti = new List<Mistnost>();
            Vlakna = new List<Vlakno>();
        }
    }
}
