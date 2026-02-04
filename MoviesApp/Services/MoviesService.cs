using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MoviesApp.Services;

public interface IMoviesService
{
    Task<List<Movie>> GetAll();
    Task<Movie?> Get(int id);
    Task Add(Movie movie);
}

public class MoviesService(MoviesDbContext context) : IMoviesService
{
    public async Task<List<Movie>> GetAll()
    {
        return await context.Movies.ToListAsync();
    }

    public async Task<Movie?> Get(int id)
    {
        return await context.Movies.FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task Add(Movie movie)
    {
        await context.Movies.AddAsync(movie);
        await context.SaveChangesAsync();
    }
}
