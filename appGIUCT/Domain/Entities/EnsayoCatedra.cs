namespace appGIUCT.Domain.Entities
{
    public class EnsayoCatedra : FormacionAcademica
    {

        public EnsayoCatedra() {
            docente = null;
            tutor = null;
        }
        public override string TipoForm => "EnsayoCatedra";
        public Person docente {get; set;}
        public Person tutor {get; set; }


    }
}