using Allegiance.Blazor.Highcharts.Services;
using Autofac;
using MarketingBox.Backoffice.Abstractions.Bo;
using MarketingBox.Backoffice.Mocks;
using MarketingBox.Backoffice.Services;
using MarketingBox.Backoffice.Services.Backoffice;
using MarketingBox.Backoffice.Services.Partners;
using MarketingBox.Backoffice.TableStorage;
using MyCrm.Auth.GrpcContracts;

namespace MarketingBox.Backoffice.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<PartnerItemManager>()
                .As<IPartnerItemManager>()
                .SingleInstance();

            RegisterGrpcService(builder);
            RegisterTableStorage(builder);
            RegisterServices(builder);
        }

        private void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<LastSearchUserCache>().As<ILastSearchUserCache>().SingleInstance();

            builder.RegisterType<BoUsersService>().As<IBoUsersService>().SingleInstance();

            builder.RegisterType<ChartService>().As<IChartService>();
        }

        private static void RegisterTableStorage(ContainerBuilder builder)
        {
            builder
                .RegisterInstance(Program.Settings.TableStorageConnectionString.CreateRolesRepository())
                .As<IBackofficeRolesRepository>()
                .SingleInstance();

            builder
                .RegisterInstance(Program.Settings.TableStorageConnectionString.CreateFiltersPresetsRepository())
                .As<IBackofficeFiltersPresetRepository>()
                .SingleInstance();
        }

        private static void RegisterGrpcService(ContainerBuilder builder)
        {
            builder.RegisterType<MyCrmUsersAuthGrpcServiceMoq>().As<IMyCrmUsersAuthGrpcService>().SingleInstance();
        }
    }
}