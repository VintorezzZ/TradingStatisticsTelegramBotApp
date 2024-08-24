using TradingStatisticsTelegramBotCore;

namespace TradingStatisticsTelegramBotApp;

public partial class MainPage : ContentPage
{
    int count = 0;
    private CancellationTokenSource _cts;
    private BotProcessor _botProcessor;

    public MainPage()
    {
        InitializeComponent();
        
        WTelegram.Helpers.Log = DefaultLogger;
        
        _cts = new CancellationTokenSource();
        _botProcessor = new BotProcessor();
        _botProcessor.Start(_cts, VerificationCodeGetter);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _btnClicked = true;
        
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private bool _btnClicked = false;
    
    private async Task<string> VerificationCodeGetter()
    {
        while (_btnClicked == false)
        {
            
        }
        
        return TelegramCodeEntry.Text;
    }
    
    private static void DefaultLogger(int level, string message)
    {
        //Console.ForegroundColor = LogLevelToColor[level];
        System.Diagnostics.Debug.WriteLine(message);
        //Console.ResetColor();
    }
}