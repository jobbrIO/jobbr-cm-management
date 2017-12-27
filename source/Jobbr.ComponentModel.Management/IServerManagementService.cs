namespace Jobbr.ComponentModel.Management
{
    public interface IServerManagementService
    {
        int MaxConcurrentJobs { get; set; }

        void Shutdown();
    }
}
