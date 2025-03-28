using System;
using System.Diagnostics;
using System.IO;

public class SessionManager
{
    private const string SessionFilePath = "session.txt";
    private const int SessionDurationDays = 7;

    public static void SaveSession(string username)
    {
        var sessionData = new SessionData
        {
            Username = username,
            LastLogin = DateTime.Now
        };

        File.WriteAllText(SessionFilePath, sessionData.ToString());
        Debug.WriteLine($"[SessionManager] Session saved for user: {username} at {sessionData.LastLogin}");
    }

    public static SessionData LoadSession()
    {
        if (!File.Exists(SessionFilePath))
        {
            Debug.WriteLine("[SessionManager] No session file found.");
            return null;
        }

        var sessionData = SessionData.FromString(File.ReadAllText(SessionFilePath));
        Debug.WriteLine($"[SessionManager] Loaded session for user: {sessionData.Username}, last login: {sessionData.LastLogin}");

        if (sessionData.LastLogin.AddDays(SessionDurationDays) < DateTime.Now)
        {
            // Session expired
            Debug.WriteLine("[SessionManager] Session expired.");
            File.Delete(SessionFilePath);
            return null;
        }

        // Refresh session
        sessionData.LastLogin = DateTime.Now;
        File.WriteAllText(SessionFilePath, sessionData.ToString());
        Debug.WriteLine($"[SessionManager] Session refreshed for user: {sessionData.Username} at {sessionData.LastLogin}");

        return sessionData;
    }

    public static void Logout()
    {
        if (File.Exists(SessionFilePath))
        {
            File.Delete(SessionFilePath);
            Debug.WriteLine("[SessionManager] Session file deleted.");
        }
    }

    public static bool ValidateAndRefreshSession()
    {
        var sessionData = LoadSession();
        if (sessionData == null)
        {
            // No session found, prompt user to sign in
            Debug.WriteLine("[SessionManager] No valid session found. Please sign in.");
            return false;
        }

        // Session is valid and refreshed
        return true;
    }
}

public class SessionData
{
    public string Username { get; set; }
    public DateTime LastLogin { get; set; }

    public override string ToString()
    {
        return $"{Username}|{LastLogin}";
    }

    public static SessionData FromString(string data)
    {
        var parts = data.Split('|');
        return new SessionData
        {
            Username = parts[0],
            LastLogin = DateTime.Parse(parts[1])
        };
    }
}
