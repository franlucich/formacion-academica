namespace appGIUCT.Domain.Entities
{
    public class PracticaSupervisadaIngenieria : FormacionAcademica
    {
        public PracticaSupervisadaIngenieria() {
            docenteSupervisor = null;
            tutor = null;
        }
        
        public Person docenteSupervisor {get; set;}
        public Person tutor {get; set;}
    }
}