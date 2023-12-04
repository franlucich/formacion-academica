namespace appGIUCT.Domain.Entities
{
    public class EnsayoCatedra : FormacionAcademica
    {

        public EnsayoCatedra() {
            docente = null;
            tutor = null;
        }
        public Person? docente {get; set;}
        public Person? tutor {get; set; }


    }
}