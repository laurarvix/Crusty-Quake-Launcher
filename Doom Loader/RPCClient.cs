using DiscordRPC.Logging;
using DiscordRPC;
using System.Diagnostics;
using System.Reflection;
using Doom_Loader.Properties;
using System.Resources;
using Doom_Loader;

public static class RPCClient
{
    public static DiscordRpcClient client;

    //Called when your application first starts. Sets up RPC
    public static void Initialize()
    {
        client = new DiscordRpcClient(Resources.DiscordAPI)
        {
            Logger = new ConsoleLogger() { Level = LogLevel.Warning }
        };

        //Subscribe to events
        client.OnReady += (sender, e) =>
        {
            Debug.WriteLine("Received Ready from user {0}", e.User.Username);
        };

        client.OnPresenceUpdate += (sender, e) =>
        {
            Debug.WriteLine("Received Update! {0}", e.Presence);
        };

        //Connect to the RPC
        client.Initialize();
    }
}