using appGIUCT.Domain.Entities;

public class PersonaIniciat
{
    public int PersonaId { get; set; }
    public Person person { get; set; }

    public int pkIniciativa { get; set; }
    public IniciativaDeInvestigacion iniciativaDeInvestigacion { get; set; }
    public string Rol { get; set; } // Puede ser "Director", "Integrante", "PIDDirigido", etc.
}