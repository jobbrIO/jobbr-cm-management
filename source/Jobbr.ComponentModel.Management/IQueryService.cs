using System.Collections.Generic;
using Jobbr.ComponentModel.Management.Model;

namespace Jobbr.ComponentModel.Management
{
    public interface IQueryService
    {
        List<Job> GetJobs(int page = 0, int pageSize = 50);

        Job GetJobById(long id);

        Job GetJobByUniqueName(string uniqueName);

        List<IJobTrigger> GetActiveTriggers();

        IJobTrigger GetTriggerById(long jobId, long triggerId);

        List<IJobTrigger> GetTriggersByJobId(long jobId);

        JobRun GetJobRunById(long id);

        List<JobRun> GetJobRuns(long page = 0, long pageSize = 50);

        List<JobRun> GetJobRunsByUserIdOrderByIdDesc(string userId);

        List<JobRun> GetJobRunsByTriggerId(long jobId, long triggerId);

        List<JobRun> GetJobRunsByUserDisplayNameOrderByIdDesc(string userDisplayName);
    }
}