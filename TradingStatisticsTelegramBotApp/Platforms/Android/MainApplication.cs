using Android.App;
using Android.Runtime;
using TradingStatisticsTelegramBotCore;

namespace TradingStatisticsTelegramBotApp;

[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp()
    {
        Configuration.IsAndroidPlatform = true;
        return MauiProgram.CreateMauiApp();
    }
}