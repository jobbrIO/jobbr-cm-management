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

        IJobTrigger GetTriggerById(long triggerId);

        List<IJobTrigger> GetTriggersByJobId(long jobId);

        JobRun GetJobRunById(long id);

        List<JobRun> GetJobRuns();

        List<JobRun> GetJobRunsByUserIdOrderByIdDesc(long userId);

        List<JobRun> GetJobRunsByTriggerId(long triggerId);

        List<JobRun> GetJobRunsByUserNameOrderByIdDesc(string userName);
    }
}