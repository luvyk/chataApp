using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Misto")]
    public class Misto
    {
        [Key]
        public int IdMisto { get; set; }
        [ForeignKey(nameof(Mistnost))]
        public int IdMistnosti { get; set; }
        [ForeignKey(nameof(Typ))]
        public int IdTyp { get; set; }
        public decimal CenaMista { get; set; }

        public virtual Mistnost Mistnost { get; set; }
        public virtual Typ Typ { get; set; }

        public virtual List<ObsazeniMista> ObsazeniMista { get; set; }

        public Misto(int idMisto, int idMistnosti, int idTyp, decimal cenaMista, Mistnost mistnost, Typ typ)
        {
            IdMisto = idMisto;
            IdMistnosti = idMistnosti;
            IdTyp = idTyp;
            CenaMista = cenaMista;
            Mistnost = mistnost;
            Typ = typ;
        }
        public Misto()
        {
            IdMisto = 0;
            IdMistnosti = 0;
            IdTyp = 0;
            CenaMista = 0;
            Mistnost = new Mistnost();
            Typ = new Typ();
        }

        public bool JeMistoObsazenoVDen(Den d)
        {
            foreach(ObsazeniMista obsazeni in ObsazeniMista)
            {
                if(obsazeni.IdDen == d.IdDen)
                { return true; }
            }
            return false;
        }
        public ObsazeniMista? VTenDenMaMisto(Den d)
        {
            foreach (ObsazeniMista obsazeni in ObsazeniMista)
            {
                if (obsazeni.IdDen == d.IdDen)
                { return obsazeni; }
            }
            return null;
        }
    }
}
