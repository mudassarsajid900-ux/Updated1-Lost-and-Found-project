namespace GAC.Application.Services.Replacement.Dtos
{
    public class ReplacementRecordDto
    {
        public long ItemId { get; set; }
        public string NewItemSerialNumber { get; set; }
        public string ReceiptImagePath { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class CreateReplacementDto
    {
        public long ItemId { get; set; }
        public string NewItemSerialNumber { get; set; }
    }

    public class GetReplacementDto : ReplacementRecordDto
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; }
    }
}
