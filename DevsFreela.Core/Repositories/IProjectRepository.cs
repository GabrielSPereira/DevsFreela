﻿using DevsFreela.Core.Entities;

namespace DevsFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();

        Task<Project?> GetByIdAsync(int id);

        Task AddAsync(Project project);

        Task SaveChangesAsync();
    }
}
