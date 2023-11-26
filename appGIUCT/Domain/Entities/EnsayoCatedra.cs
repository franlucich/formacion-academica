namespace appGIUCT.Domain.Entities
{
    public class EnsayoCatedra : FormacionAcademica
    {
        public EnsayoCatedra() {
            docente = null;
            tutor = null;
        }
        
        public Persona docente {get; set;}
        public Persona tutor {get; set; }

    }
}