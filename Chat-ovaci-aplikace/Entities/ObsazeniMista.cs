using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("ObsazeniMista")]
    public class ObsazeniMista
    {
        [Key]
        public int IdObsazeni {  get; set; }
        [ForeignKey(nameof(misto))]
        public int IdMista { get; set; }
        [ForeignKey(nameof(den))]
        public int IdDen {  get; set; }
        [ForeignKey(nameof(ucastnik))]
        public int IdUcastnik { get; set; }
        
        public virtual Misto misto { get; set; }
        public virtual Den den {  get; set; }
        public virtual Ucastnik ucastnik { get; set; }

        public ObsazeniMista(int idObsazeni, int idMista, int idDen, int idUcastnik, Misto misto, Den den, Ucastnik ucastnik)
        {
            IdObsazeni = idObsazeni;
            IdMista = idMista;
            IdDen = idDen;
            IdUcastnik = idUcastnik;
            this.misto = misto;
            this.den = den;
            this.ucastnik = ucastnik;
        }

        public ObsazeniMista()
        {
            IdObsazeni = 0;
            IdMista = 0;
            IdDen = 0;
            IdUcastnik = 0;
            this.misto = new Misto();
            this.den = new Den();
            this.ucastnik = new Ucastnik();
        }
    }
}
