open System
    
open SM64.Net.TwitchBot.Bot

[<EntryPoint>]
let main _argv =
    let config: BotConfig =
        { TwitchCredentials =
            { UserName = "sm64dotnet"
              OAuthToken = Environment.GetEnvironmentVariable "SM64DOTNET_TWITCH_OAUTH_TOKEN" }
            
          ChannelsToJoin = [
              { Username = "stachudotnet" }
          ] }
    
    printfn "starting twitch bot"    
    startTwitchBot config
    printfn "started twitch bot"
    
    Console.ReadKey() |> ignore
    
    printfn "twitch bot died"
    
    0