using System;
using System.Collections.Generic;
using System.IO;
using Jobbr.ComponentModel.Management.Model;

namespace Jobbr.ComponentModel.Management
{
    public interface IJobManagementService
    {
        List<Job> GetAllJobs();

        Job GetJobById(long id);

        Job AddJob(Job job);

        Job GetJobByUniqueName(string uniqueName);


        List<IJobTrigger> GetActiveTriggers();

        long AddTrigger(RecurringTrigger trigger);

        long AddTrigger(ScheduledTrigger trigger);

        long AddTrigger(InstantTrigger trigger);

        bool DisableTrigger(long triggerId);

        bool EnableTrigger(long triggerId);

        JobRun GetJobRunById(long id);


        List<JobRun> GetJobRuns();

        IJobTrigger GetTriggerById(long triggerId);

        List<IJobTrigger> GetTriggersByJobId(long jobId);

        List<JobRun> GetJobRunsByUserOrderByIdDesc(long userId);

        List<JobRun> GetJobRunsByTriggerId(long triggerId);

        List<JobRun> GetJobRunsByUserNameOrderOrderByIdDesc(string userName);

        List<JobArtefact> GetArtefactForJob(JobRun jobRun);

        Stream GetArtefactAsStream(JobRun jobRun, string filename);

        void UpdateTriggerDefinition(long triggerId, string definition);

        void UpdatetriggerStartTime(long triggerId, DateTime startDateTimeUtc);
    }
}