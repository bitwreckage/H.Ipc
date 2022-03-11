﻿namespace H.Ipc.Generator.IntegrationTests;

[TestClass]
public class IpcGeneratorSnapshotTests : VerifyBase
{
    [TestMethod]
    public Task GeneratesIpcClientAndIpcServerCorrectly()
    {
        return this.CheckSource(@"
namespace H.Ipc.Apps.Wpf;

public interface IActionService
{
    void ShowTrayIcon();
    void HideTrayIcon();
}

[H.IpcGenerators.IpcClient]
public partial class ActionServiceClient : IActionService
{
}

[H.IpcGenerators.IpcServer]
public partial class ActionService : IActionService
{
    public void ShowTrayIcon()
    {
    }

    public void HideTrayIcon()
    {
    }
}");
    }
}