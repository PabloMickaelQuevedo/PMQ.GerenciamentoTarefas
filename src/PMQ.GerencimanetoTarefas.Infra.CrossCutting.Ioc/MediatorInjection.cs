﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PMQ.GerencimanetoTarefas.Infra.CrossCutting.Ioc
{
    public static class MediatorInjection
    {
        private static Assembly DomainAssembly => AppDomain.CurrentDomain.Load("PMQ.GerenciamentoTarefas.Domain");

        public static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(DomainAssembly));
        }
    }
}
