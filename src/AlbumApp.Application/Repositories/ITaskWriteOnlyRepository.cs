namespace TaskApp.Application.Repositories{
    

    public interface ITaskWriteOnlyRepository
    {
        System.Threading.Tasks.Task Add(Domain.Tasks.Artista task);
        System.Threading.Tasks.Task Update(Domain.Tasks.Artista task);
        System.Threading.Tasks.Task Delete(Domain.Tasks.Artista task);
    }
}
