namespace appGIUCT.Domain.Entities
{
    public class ProyectoFinalIngenieria : IEntity
    {
        public ProyectoFinalIngenieria() {
            director = null;
            fuenteFinanciemiento = "";
        }
        public Person director {get; set; }
        public string fuenteFinanciemiento {get; set;}
   
      public int pkFormacionAcademica {get; set;}

        public FormacionAcademica formacionAcademicas {get; set;}

      public PersonFormacionAcademica PersonaFormacionAcademica { get; set; }
    }
}