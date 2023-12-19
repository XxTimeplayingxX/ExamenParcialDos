using CommunityToolkit.Maui.Alerts;

namespace ExamenParcialDos;
public class Util
{
    public static async Task ShowToastAsync(string message)
    {
        // implement your logic here
        var toast = Toast.Make(message);
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        await toast.Show(cts.Token);
    }
}
