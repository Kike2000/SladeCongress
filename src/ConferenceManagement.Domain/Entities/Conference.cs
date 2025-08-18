namespace ConferenceManagement.Domain.Entities
{
    public class Conference
    {
        public Conference()
        {
            
        }
        public int ConferenceId { get; set; }
        public required Guid PublicId { get; set; }
        public required string Title { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
