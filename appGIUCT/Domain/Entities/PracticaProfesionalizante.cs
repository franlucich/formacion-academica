namespace appGIUCT.Domain.Entities
{
    public class PracticaProfesionalizante : FormacionAcademica
    {
        public PracticaProfesionalizante() {
            docente = null;
            tutor = null;
        }
        public override string TipoForm => "PracticaProfecionalizante";
        public Person docente {get; set;}
        public Person tutor {get; set;}

        
        
    }
}