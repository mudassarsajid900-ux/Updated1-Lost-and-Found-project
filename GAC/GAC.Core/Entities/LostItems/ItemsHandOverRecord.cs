using GAC.Core.Entities.Claims;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.LostItems
{
    public class ItemsHandOverRecord : BaseEntity
    {
        public long ClaimRequestId { get; set; }
        [ForeignKey("ClaimRequestId")] public ClaimRequest ClaimRequest { get; set; }
        public string CnicImagePath { get; set; }
        public string PersonImagePath { get; set; }

    }
}
