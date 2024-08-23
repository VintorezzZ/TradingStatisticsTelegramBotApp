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
        
        _cts = new CancellationTokenSource();
        _botProcessor = new BotProcessor();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await _botProcessor.Start(_cts);
        
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}