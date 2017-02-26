using System;
using System.Collections.Generic;
using System.IO;
using Jobbr.ComponentModel.Management.Model;

namespace Jobbr.ComponentModel.Management
{
    public interface IJobManagementService
    {
        Job AddJob(Job job);

        long AddTrigger(RecurringTrigger trigger);

        long AddTrigger(ScheduledTrigger trigger);

        long AddTrigger(InstantTrigger trigger);

        bool DisableTrigger(long triggerId);

        bool EnableTrigger(long triggerId);

        List<JobArtefact> GetArtefactForJob(Guid jobRunUniqueId);

        Stream GetArtefactAsStream(Guid jobRunUniqueId, string filename);

        void UpdateTriggerDefinition(long triggerId, string definition);

        void UpdateTriggerStartTime(long triggerId, DateTime startDateTimeUtc);
    }
}