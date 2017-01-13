using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProjet.Models
{
    class Joueur
    {
        public string Email { get; set; }

        public int MotDePass { get; set; }
        public string NomEtPrenom { get; set; }
        public string NumTel { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Match> MatchOrganiser { get; set; }
        public ICollection<MatchJoueur> MatchsParticiper { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
