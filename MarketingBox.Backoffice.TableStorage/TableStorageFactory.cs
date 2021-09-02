using MarketingBox.Backoffice.TableStorage.FilterPresets;
using MarketingBox.Backoffice.TableStorage.Roles;
using MyAzureTableStorage;

namespace MarketingBox.Backoffice.TableStorage
{
    public static class TableStorageFactory
    {
        public static TableStorageRoleRepository CreateRolesRepository(this string connectionString)
        {
            return
                new(
                    new AzureTableStorage<TableStorageBackofficeRoleModel>(() => connectionString, "UserRoles"));
        }
        
        public static TableStorageLogsPresetRepository CreateFiltersPresetsRepository(this string connectionString)
        {
            return
                new(
                    new AzureTableStorage<TableStorageFilterPresetModel>(() => connectionString, "FiltersPresets"));
        }
    }
}