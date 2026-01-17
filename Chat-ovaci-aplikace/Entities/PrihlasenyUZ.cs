using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("PrihlasenyUZ")]
    public class PrihlasenyUZ
    {
        [Key]
        public int IdPrihlaseni { get; set; }
        public DateTime DateTimePrihlaseni { get; set; }
        public string Token { get; set; }
        [ForeignKey(nameof(Uzivatel))]
        public int IdUzivatel { get; set; }

        public Uzivatel Uzivatel { get; set; }

        public PrihlasenyUZ(int idPrihlaseni, DateTime dateTimePrihlaseni, string token, int idUzivatel, Uzivatel uzivatel)
        {
            IdPrihlaseni = idPrihlaseni;
            DateTimePrihlaseni = dateTimePrihlaseni;
            Token = token;
            IdUzivatel = idUzivatel;
            Uzivatel = uzivatel;
        }
        public PrihlasenyUZ()
        {
            IdPrihlaseni = 0;
            DateTimePrihlaseni = DateTime.Now;
            Token = string.Empty;
            IdUzivatel = 0;
            Uzivatel = new Uzivatel();
        }
    }
}
