using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.Locations
{
    public class Location :BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
}
