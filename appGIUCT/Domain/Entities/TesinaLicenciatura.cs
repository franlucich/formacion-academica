namespace appGIUCT.Domain.Entities
{
    public class TesinaLicenciatura : IEntity
    {
        public TesinaLicenciatura() {
            director = null;
            fuenteFinanciamiento = "";
        }
        
        public Person director {get; set;}
        public string fuenteFinanciamiento {get; set;}
        public FormacionAcademica formacionAcademica { get; set; }
        public int pkFormacionAcademica { get; set; }


    }
}