namespace appGIUCT.Domain.Entities
{
    public class ProyectoFinalIngenieria : FormacionAcademica
    {
        public ProyectoFinalIngenieria() {
            director = null;
            fuenteFinanciemiento = "";
        }
        public Person director {get; set; }
        public string fuenteFinanciemiento {get; set;}
   


    }
}