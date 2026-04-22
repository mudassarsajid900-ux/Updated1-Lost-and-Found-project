using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.ItemTypes;

public class Fields : BaseEntity
{
    public long ItemTypeId { get; set; }
    public ItemType ItemType { get; set; }
    [StringLength(200)]
    public string FieldName { get; set; }
    
    [StringLength(50)]
    public string FieldType { get; set; } = "text"; // text, toggle, number, date
    
    public string? Options { get; set; } // Comma separated options for dropdowns (planned)

}
