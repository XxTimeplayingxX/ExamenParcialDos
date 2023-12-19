namespace ExamenParcialDos.Models;

public class Settings
{
    public static bool IsAuthenticated
    {
        get => Preferences.Default.Get(nameof(IsAuthenticated), false);
        set => Preferences.Default.Set(nameof(IsAuthenticated), value);
    }

    public static string Email
    {
        get => Preferences.Default.Get(nameof(Email), string.Empty);
        set => Preferences.Default.Set(nameof(Email), value);
    }
    public static string Pregunta1
    {
        get => Preferences.Default.Get(nameof(Pregunta1), string.Empty);
        set => Preferences.Default.Set(nameof(Pregunta2), value);
    }
    public static string Pregunta2
    {
        get => Preferences.Default.Get(nameof(Pregunta2), string.Empty);
        set => Preferences.Default.Set(nameof(Pregunta2), value);
    }
    public static string Pregunta3
    {
        get => Preferences.Default.Get(nameof(Pregunta3), string.Empty);
        set => Preferences.Default.Set(nameof(Pregunta3), value);
    }
}
