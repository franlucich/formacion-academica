namespace appGIUCT.Domain.Entities
{
    public abstract class FormacionAcademica : IEntity
    {
        
        public date fechaInicio {get; set;}
        public date fechaFin {get; set;}
        public string titulo {get; set;}
    }
}