using System;

namespace Jobbr.ComponentModel.Management.Model
{
    public class RecurringTrigger : IJobTrigger
    {
        public DateTime? StartDateTimeUtc { get; set; }

        public DateTime? EndDateTimeUtc { get; set; }

        public string Definition { get; set; }
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
