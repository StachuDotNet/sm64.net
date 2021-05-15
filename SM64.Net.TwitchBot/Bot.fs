module SM64.Net.TwitchBot.Bot

open System
open SM64.Speedrunning.Core

open TwitchLib.Client
open TwitchLib.Client.Models
open TwitchLib.Communication.Clients
open TwitchLib.Communication.Models
let channelsToJoin = ["stachudotnet"; "lvrkd"; "benji64"; "luuuwun"; "simply"]

type BotConfig = { TwitchCredentials: TwitchCredentials }
and TwitchCredentials = { UserName: string; OAuthToken: string }

let friendlyTime (ts: TimeSpan) =
    let hours = ts.Hours
    let minutes = ts.Minutes
    let seconds = ts.Seconds
    
    match hours, minutes with
    | 0, 0 -> sprintf "%i seconds" seconds
    | 0, _ -> sprintf "%i minutes and %i seconds" minutes seconds
    | _, _ -> sprintf "%ih %imin %is" hours minutes seconds

let logEx (ex: Exception) = printfn "Ex: %s" ex.Message

let handleMessage (client: TwitchClient) (evt: Events.OnMessageReceivedArgs) =
    let chatMessage = evt.ChatMessage
    let msg = chatMessage.Message.ToLower()
    let incomingChannel = chatMessage.Channel
    
    let handleSingleLeaderboard category =
        try 
            let data = SpeedrunDotCom.Client.GetCategory.getRankings category
            let wr = data.runs |> Seq.find(fun r -> r.place = 1)
            let wrTime =  TimeSpan.FromSeconds(wr.run.times.primary_t) |> friendlyTime
            let categoryName = categoryName category
            
            let outgoingMsg = sprintf "The WR for %s is %s" categoryName wrTime
            client.SendMessage(incomingChannel, outgoingMsg)
        with | ex -> logEx ex
    
    match msg with
    | "!sm64 wr 0" -> handleSingleLeaderboard SpeedrunningCategory.ZeroStar
    | "!sm64 wr 1" -> handleSingleLeaderboard SpeedrunningCategory.OneStar
    | "!sm64 wr 16" -> handleSingleLeaderboard SpeedrunningCategory.SixteenStar
    | "!sm64 wr 70" -> handleSingleLeaderboard SpeedrunningCategory.SeventyStar
    | "!sm64 wr 120" -> handleSingleLeaderboard SpeedrunningCategory.OneTwentyStar
    
    | "!sm64 people [simply] records" -> failwith "todo"
    
    | "!sm64" -> client.SendMessage(incomingChannel, "WIP/Testing. Commands available: !sm64 records")
    
    | msg when msg.StartsWith("!sm64 suggest") ->
        client.SendMessage(incomingChannel, sprintf "Thanks for the suggestion, %s!" chatMessage.Username)
        msg |> printfn "unhandled: %s"
    | _ -> ()

let startTwitchBot (config: BotConfig) =
    let credentials = ConnectionCredentials(config.TwitchCredentials.UserName, config.TwitchCredentials.OAuthToken)

    let customClient =
        let clientOptions = ClientOptions()
        clientOptions.MessagesAllowedInPeriod <- 750
        clientOptions.ThrottlingPeriod <- TimeSpan.FromSeconds 30.
        WebSocketClient(clientOptions)
    
    let client = TwitchClient(customClient)
    client.Initialize(credentials, "sm64dotnet")
    client.OnMessageReceived.Add (fun msg -> handleMessage client msg)
    client.Connect()
    
//    channelsToJoin
//    |> Seq.iter(fun chName -> client.JoinChannel(chName, true))


// -- todos/notes --

//!sm64 records
//!sm64 records [categoryName]
//!sm64 rankings
//!sm64 rankings [categoryName]
//!sm64 routes
//!sm64 routes [categoryName]
//!sm64 people
//!sm64 people [name or nickname]
//!sm64 hack [hackName]
//
//subscribe to new records
//subscribe to pacers
//subscribe to new hacks
//
//speedrun.com/api
//sm64 gameId: sm64
//category IDs
//
//get the pbs of a single runner
//
//custom shortcuts for given channel
//e.g. !sm64 pbs -> !sm64 people [simply] records
//e.g. !sm64 pb 16 -> !sm64 people [simply] records [16]
