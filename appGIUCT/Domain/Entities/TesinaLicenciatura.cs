namespace appGIUCT.Domain.Entities
{
    public class TesinaLicenciatura : FormacionAcademica
    {
        public TesinaLicenciatura() {
            director = null;
            fuenteFinanciamiento = "";
        }
        
        public Persona director {get; set;}
        public string fuenteFinanciamiento {get; set;}

    }
}