using Repository.Pattern.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using WebApp.Repositories;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class UnHandledErrorsService : Service<UnHandledErrors>, IUnHandledErrorsService
    {
        private readonly IRepositoryAsync<UnHandledErrors> _repository;
        public UnHandledErrorsService(IRepositoryAsync<UnHandledErrors> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}