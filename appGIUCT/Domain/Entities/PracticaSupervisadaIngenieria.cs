namespace appGIUCT.Domain.Entities
{
    public class PracticaSupervisadaIngenieria : FormacionAcademica
    {
        public PracticaSupervisadaIngenieria() {
            docenteSupervisor = null;
            tutor = null;
        }
        public override string TipoForm => "PracticaSupervisadaIngenieria";
        public Person docenteSupervisor {get; set;}
        public Person tutor {get; set;}
        

    }
}