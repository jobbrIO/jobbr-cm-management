using System;
using System.Collections.Generic;
using System.IO;
using Jobbr.ComponentModel.Management.Model;

namespace Jobbr.ComponentModel.Management
{
    public interface IJobManagementService
    {
        void AddJob(Job job);

        void AddTrigger(long jobId, RecurringTrigger trigger);

        void AddTrigger(long jobId, ScheduledTrigger trigger);

        void AddTrigger(long jobId, InstantTrigger trigger);

        void DisableTrigger(long jobId, long triggerId);

        void EnableTrigger(long jobId, long triggerId);

        List<JobArtefact> GetArtefactForJob(long jobRunId);

        Stream GetArtefactAsStream(long jobRunId, string filename);

        void UpdateTriggerDefinition(long jobId, long triggerId, string definition);

        void UpdateTriggerStartTime(long jobId, long triggerId, DateTime startDateTimeUtc);
    }
}