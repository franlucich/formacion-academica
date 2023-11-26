namespace appGIUCT.Domain.Entities
{
    public class IniciativaDeInvestigacion : IEntity
    {
        public IniciativaDeInvestigacion() {
            codigo = 0;
            descripcion = "";
            duracion = 0;
            estado = "";
            titulo = "";
            fechaFin = null ;
            fechaInicio = null;
        }
        
        public int codigo {get; set;}
        public string descripcion {get; set;}
        public int duracion {get; set;}
        public string estado {get; set;}
        public date fechaFin {get; set;}
        public date fechaInicio {get; set;}
        public string titulo {get; set;}

    }
}