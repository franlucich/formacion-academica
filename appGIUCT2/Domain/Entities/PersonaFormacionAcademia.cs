namespace appGIUCT.Domain.Entities;
public class PersonFormacionAcademica
{
    public int PersonId { get; set; }
    public Person Persona { get; set; }

    public int FormacionAcademicaId { get; set; }
    public FormacionAcademica FormacionAcademica { get; set; }
}