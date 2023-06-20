namespace TaskApp.Application.Repositories
{    
    using System;
    using System.Collections.Generic;

    public interface ITaskReadOnlyRepository
    {
        System.Threading.Tasks.Task<Domain.Tasks.Artista> Get(Guid id);
        System.Threading.Tasks.Task<IList<Domain.Tasks.Artista>> GetTasks();
        System.Threading.Tasks.Task<IList<Domain.Tasks.Artista>> GetTasksByDescription(string description);
        
    }
}
