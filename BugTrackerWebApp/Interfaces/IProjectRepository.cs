﻿using BugTrackerWebApp.Models;

namespace BugTrackerWebApp.Interfaces;

public interface IProjectRepository
{
    Task<IEnumerable<Project>> GetAll();
    Task<Project> GetById(int id);
    Task<Project> GetByName(string name);
    bool Add(Project club);
    bool Update(Project club);
    bool Delete(Project club);
    bool Save();
}