namespace appGIUCT.Domain.Entities
{
    public class PracticaSupervisadaIngenieria : IEntity
    {
        public PracticaSupervisadaIngenieria() {
            docenteSupervisor = null;
            tutor = null;
        }
        
        public Person docenteSupervisor {get; set;}
        public Person tutor {get; set;}
        public FormacionAcademica formacionAcademica { get; set; }
        public int pkFormacionAcademica { get; set; }

    }
}