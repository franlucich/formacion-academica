namespace appGIUCT.Domain.Entities
{
    public abstract class FormacionAcademica : IEntity
    {
        
        public DateTime fechaInicio {get; set;}
        public DateTime fechaFin {get; set;}
        public string titulo {get; set;}
    }
}