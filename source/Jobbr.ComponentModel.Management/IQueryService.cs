using System;
using System.Collections.Generic;
using Jobbr.ComponentModel.Management.Model;

namespace Jobbr.ComponentModel.Management
{
    public interface IQueryService
    {
        Job GetJobById(long id);

        Job GetJobByUniqueName(string uniqueName);

        PagedResult<Job> GetJobs(int page = 1, int pageSize = 50, string jobTypeFilter = null, string jobUniqueNameFilter = null, string query = null, params string[] sort);

        PagedResult<IJobTrigger> GetActiveTriggers(int page = 1, int pageSize = 50, string jobTypeFilter = null, string jobUniqueNameFilter = null, string query = null, params string[] sort);

        IJobTrigger GetTriggerById(long jobId, long triggerId);

        List<IJobTrigger> GetTriggersByJobId(long jobId);

        JobRun GetJobRunById(long id);

        List<JobRun> GetJobRuns(int page = 1, int pageSize = 50, string jobTypeFilter = null, string jobUniqueNameFilter = null, string query = null, params string[] sort);

        PagedResult<JobRun> GetJobRunsByUserId(string userId, int page = 1, int pageSize = 50, string jobTypeFilter = null, string jobUniqueNameFilter = null, params string[] sort);

        PagedResult<JobRun> GetJobRunsByTriggerId(long jobId, long triggerId, int page = 1, int pageSize = 50, params string[] sort);

        PagedResult<JobRun> GetJobRunsByUserDisplayName(string userDisplayName, int page = 1, int pageSize = 50, string jobTypeFilter = null, string jobUniqueNameFilter = null, params string[] sort);

        PagedResult<JobRun> GetJobRunsByState(JobRunStates state, int page = 1, int pageSize = 50, string jobTypeFilter = null, string jobUniqueNameFilter = null, string query = null, params string[] sort);

        JobRun GetLastJobRunByTriggerId(long jobId, long triggerId, DateTime utcNow);

        JobRun GetNextJobRunByTriggerId(long jobId, long triggerId, DateTime utcNow);
    }
}