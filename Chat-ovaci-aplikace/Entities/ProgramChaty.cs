using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Program")]
    public class ProgramChaty
    {
        [Key]
        public int IdProgramu { get; set; }
        [ForeignKey(nameof(Den))]
        public int IdDen { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public DateTime CasZacatku { get; set; }
        public DateTime CasKonce { get; set; }

        public virtual Den Den { get; set; }

        public ProgramChaty(int idProgramu, int idDen, string nazev, string popis, DateTime casZacatku, DateTime casKonce, Den den)
        {
            IdProgramu = idProgramu;
            IdDen = idDen;
            Nazev = nazev;
            Popis = popis;
            CasZacatku = casZacatku;
            CasKonce = casKonce;
            Den = den;
        }
        public ProgramChaty()
        {
            IdProgramu = 0;
            IdDen = 0;
            Nazev = string.Empty;
            Popis = string.Empty;
            CasZacatku = DateTime.Now;
            CasKonce = DateTime.Now;
            Den = new Den();
        }
    }
}
