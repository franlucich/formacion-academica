namespace appGIUCT.Domain.Entities
{
    public class TesisPosgrado : FormacionAcademica
    {
        public TesisPosgrado() {
            director = null;
            fuenteFinanciamiento = "";
            tipo = "";
        }
        public Person? director {get; set;}
        public string? fuenteFinanciamiento {get; set;}
        public string? tipo {get; set;}
   

    }
}