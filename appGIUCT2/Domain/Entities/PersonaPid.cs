using appGIUCT.Domain.Entities;

public class PersonaPID
{
    public int PersonaId { get; set; }
    public Person person { get; set; }

    public int PIDId { get; set; }
    public Pid PID { get; set; }
    public string Rol { get; set; } // Puede ser "Director", "Integrante", "PIDDirigido", etc.
}