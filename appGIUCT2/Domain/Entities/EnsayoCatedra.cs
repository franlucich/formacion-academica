namespace appGIUCT.Domain.Entities
{
    public class EnsayoCatedra : IEntity
    {

        public EnsayoCatedra() {
            docente = null;
            tutor = null;
        }

        public int pkFormacionAcademica {get; set;}

        public FormacionAcademica formacionAcademicas {get; set;}

        public Person docente {get; set;}
        public Person tutor {get; set; }




    }
}