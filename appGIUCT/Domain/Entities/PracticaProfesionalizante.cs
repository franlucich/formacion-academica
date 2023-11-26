namespace appGIUCT.Domain.Entities
{
    public class PracticaProfesionalizante : FormacionAcademica
    {
        public PracticaProfesionalizante() {
            docente = null;
            tutor = null;
        }
        
        public Persona docente {get; set;}
        public Persona tutor {get; set;}

    }
}