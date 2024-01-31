﻿using DevsFreela.Application.InputModels;
using DevsFreela.Application.Services.Interfaces;
using DevsFreela.Application.ViewModels.Project;
using DevsFreela.Core.Entities;
using DevsFrella.Infrastructure.Persistence;

namespace DevsFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevsFreelaDbContext _dbContext;
        public ProjectService(DevsFreelaDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public int Create(NewProjectInputModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
            _dbContext.Projects.Add(project);

            return project.Id;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdProject, inputModel.IdUser);
            _dbContext.ProjectComments.Add(comment);
        }

        public void Delete(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            project?.Cancel();
        }

        public void Finish(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            project?.Finish();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbContext.Projects;
            var projectsViewModel = projects.Select(x => new ProjectViewModel(x.Id, x.Title, x.CreatedAt)).ToList();
            return projectsViewModel;
        }

        public ProjectDetailsViewModel? GetById(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            if (project != null)
            {
                var projectViewModel = new ProjectDetailsViewModel(
                    project.Id,
                    project.Title,
                    project.Description,
                    project.TotalCost,
                    project.StartedAt,
                    project.FinishedAt
                );

                return projectViewModel;
            }

            return null;
        }

        public void Start(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            project?.Start();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == inputModel.Id);
            project?.Update(inputModel.Title, inputModel.Description, inputModel.TotalCost);
        }
    }
}