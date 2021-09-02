﻿using Backoffice.Abstractions.Bo;
using Backoffice.Caches;
using Backoffice.GlobalTimers;
using Backoffice.Services;
using DotNetCoreDecorators;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyJetWallet.Sdk.Service;
using System;

namespace Backoffice
{
    public class ApplicationLifetimeManager : ApplicationLifetimeManagerBase
    {
        private readonly ILogger<ApplicationLifetimeManager> _logger;
        private readonly IBackofficeRolesRepository _backofficeRolesRepository;
        private readonly ILoggerFactory _loggerFactory;

        private static readonly TaskTimer StatusTimer = new(TimeSpan.FromSeconds(30));

        public ApplicationLifetimeManager(
            IHostApplicationLifetime appLifetime, 
            ILogger<ApplicationLifetimeManager> logger,
            IBackofficeRolesRepository backofficeRolesRepository,
            IBoUsersService boUsersService,
            ILoggerFactory loggerFactory
            )
            : base(appLifetime)
        {
            _logger = logger;
            _backofficeRolesRepository = backofficeRolesRepository;
            _loggerFactory = loggerFactory;

            HttpUtils.BoUsersService = boUsersService;
        }

        protected override void OnStarted()
        {
            _logger.LogInformation("OnStarted has been called.");
            
            //StatusTimer.Register("CacheSync", async () =>
            //{
                
            //});

            StatusTimer.Register("BoDataSync", async () =>
            {
                RolesCache.SyncData(await _backofficeRolesRepository.GetAllRolesAsync());
            });

            StatusTimer.Start();
            
            RefreshTimer.SetupTimer(_loggerFactory.CreateLogger("RefreshTimer"), TimeSpan.FromSeconds(5));
        }

        protected override void OnStopping()
        {
            _logger.LogInformation("OnStopping has been called.");
            
            RefreshTimer.StopTimer();
            
            StatusTimer.Stop();
        }

        protected override void OnStopped()
        {
            _logger.LogInformation("OnStopped has been called.");
        }
    }
}