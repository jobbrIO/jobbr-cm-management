using System.Collections.Generic;
using Jobbr.ComponentModel.Management.Model;

namespace Jobbr.ComponentModel.Management
{
    public interface IQueryService
    {
        List<Job> GetAllJobs();

        Job GetJobById(long id);

        Job GetJobByUniqueName(string uniqueName);

        List<IJobTrigger> GetActiveTriggers();

        JobRun GetJobRunById(long id);

        List<JobRun> GetJobRuns();

        IJobTrigger GetTriggerById(long triggerId);

        List<IJobTrigger> GetTriggersByJobId(long jobId);

        List<JobRun> GetJobRunsByUserOrderByIdDesc(long userId);

        List<JobRun> GetJobRunsByTriggerId(long triggerId);

        List<JobRun> GetJobRunsByUserNameOrderOrderByIdDesc(string userName);
    }
}