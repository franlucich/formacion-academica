namespace appGIUCT.Domain.Entities
{
    public class ProyectoFinalIngenieria : FormacionAcademica
    {
        public ProyectoFinalIngenieria() {
            director = null;
            fuenteFinanciamiento = "";
        }

        public Persona director {get; set; }
        public string fuenteFinanciemiento {get; set;}

    }
}