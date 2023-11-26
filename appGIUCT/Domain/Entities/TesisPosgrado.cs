namespace appGIUCT.Domain.Entities
{
    public class TesisPosgrado : IEntity
    {
        public TesisPosgrado() {
            director = null;
            fuenteFinanciamiento = "";
            tipo = "";
        }
        
        public Person director {get; set;}
        public string fuenteFinanciamiento {get; set;}
        public string tipo {get; set;}
        public FormacionAcademica formacionAcademica { get; set; }
        public int pkFormacionAcademica { get; set; }

    }
}