namespace Jobbr.ComponentModel.Management.Model
{
    public interface IJobTrigger
    {
        long Id { get; set; }

        string Comment { get; set; }

        bool IsActive { get; set; }

        string Parameters { get; set; }

        string UserDisplayName { get; set; }

        long? UserId { get; set; }

        string UserName { get; set; }

        long JobId { get; set; }
    }
}