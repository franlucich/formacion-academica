namespace appGIUCT.Domain.Entities
{
    public class PracticaSupervisadaIngenieria : FormacionAcademica
    {
        public PracticaSupervisadaIngenieria() {
            docenteSupervisor = null;
            tutor = null;
        }
        
        public Persona docenteSupervisor {get; set;}
        public Persona tutor {get; set;}
    }
}