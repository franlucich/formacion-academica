namespace appGIUCT.Domain.Entities
{
    public class PracticaProfesionalizante : IEntity
    {
        public PracticaProfesionalizante() {
            docente = null;
            tutor = null;
        }
        
        public Person docente {get; set;}
        public Person tutor {get; set;}
        public FormacionAcademica formacionAcademica { get; set; }
        public int pkFormacionAcademica { get; set; }

    }
}