﻿namespace HappyMe.Services.Data.Contracts
{
    using System.Linq;

    using HappyMe.Data.Models;
    using HappyMe.Services.Common;

    public interface IModulesDataService : IService
    {
        IQueryable<Module> All();

        IQueryable<Module> AllWithQuestions();

        IQueryable<Module> AllActive();

        IQueryable<Module> AllActiveWithQuestions();

        IQueryable<Module> AllPublic();

        IQueryable<Module> AllPublicWithQuestionsWithCorrectAnswer();

        Module GetById(int id);
    }
}
