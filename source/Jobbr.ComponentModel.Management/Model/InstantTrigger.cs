namespace Jobbr.ComponentModel.Management.Model
{
    public class InstantTrigger : IJobTrigger
    {
        public int DelayedMinutes { get; set; }
        public long Id { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }
        public string Parameters { get; set; }
        public string UserDisplayName { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public long JobId { get; set; }
    }
}