namespace MarketingBox.Backoffice.Modules
{
    //public class MyNoSqlModule : Module
    //{
    //    protected override void Load(ContainerBuilder builder)
    //    {
    //        RegisterMyNoSqlWriter<BitgoAssetMapEntity>(builder, BitgoAssetMapEntity.TableName);
    //        RegisterMyNoSqlWriter<BitgoCoinEntity>(builder, BitgoAssetMapEntity.TableName);
    //        RegisterMyNoSqlWriter<AssetPaymentSettingsNoSqlEntity>(builder, AssetPaymentSettingsNoSqlEntity.TableName);
    //        RegisterMyNoSqlWriter<MarketInfoNoSqlEntity>(builder, MarketInfoNoSqlEntity.TableName);
    //        RegisterMyNoSqlWriter<CMCApiKeyNoSqlEntity>(builder, CMCApiKeyNoSqlEntity.TableName);

    //        RegisterAuthMyNoSqlWriter<RootSessionNoSqlEntity>(builder,RootSessionNoSqlEntity.TableName);
    //        RegisterAuthMyNoSqlWriter<ShortRootSessionNoSqlEntity>(builder,ShortRootSessionNoSqlEntity.TableName);
    //    }

    //    private static void RegisterMyNoSqlWriter<TEntity>(ContainerBuilder builder, string table)
    //        where TEntity : IMyNoSqlDbEntity, new()
    //    {
    //        builder.Register(ctx => new MyNoSqlServer.DataWriter.MyNoSqlServerDataWriter<TEntity>(
    //                Program.ReloadedSettings(e => e.MyNoSqlWriterUrl), table, true))
    //            .As<IMyNoSqlServerDataWriter<TEntity>>()
    //            .AutoActivate()
    //            .SingleInstance();
    //    }
        
    //    private static void RegisterAuthMyNoSqlWriter<TEntity>(ContainerBuilder builder, string table)
    //        where TEntity : IMyNoSqlDbEntity, new()
    //    {
    //        builder.Register(ctx => new MyNoSqlServer.DataWriter.MyNoSqlServerDataWriter<TEntity>(
    //                Program.ReloadedSettings(e => e.AuthMyNoSqlWriterUrl), table, true))
    //            .As<IMyNoSqlServerDataWriter<TEntity>>()
    //            .SingleInstance();
    //    }
    //}
}