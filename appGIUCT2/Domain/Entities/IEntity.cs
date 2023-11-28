using System.ComponentModel.DataAnnotations;

namespace appGIUCT.Domain.Entities {
    public class IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
 }