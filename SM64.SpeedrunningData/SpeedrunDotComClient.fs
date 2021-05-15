module SpeedrunDotCom.Client

open System

open System.Net.Http
open Newtonsoft.Json
open Newtonsoft.Json.Serialization

open SM64.Speedrunning.Core
open SM64.Utils

let baseUrl = "https://speedrun.com/api/v1"

let getCategoryId (category: SpeedrunningCategory) =
    match category with
    | ZeroStar -> "xk9gg6d0"
    | OneStar -> "7kjpp4k3"
    | SixteenStar -> "n2y55mko"
    | FiftyStar -> failwith "unknown"
    | SeventyStar -> "7dgrrxk4"
    | OneTwentyStar -> "wkpoo02r"

type Response<'a> = { Data: 'a }

let sharedClient = new HttpClient()

let serializerSettings =
    let settings = JsonSerializerSettings(ContractResolver = CamelCasePropertyNamesContractResolver())
    settings.Converters.Add (OptionConverter())
    settings

let makeRequest<'response> url : 'response =
    let request = new HttpRequestMessage()
    request.Method <- HttpMethod.Get
    request.RequestUri <- Uri(url)
    request.Headers.Add("User-Agent", "sm64dotnet")

    let response = sharedClient.GetAsync url |> Async.AwaitTask |> Async.RunSynchronously

    let response = response.Content.ReadAsStringAsync() |> Async.AwaitTask |> Async.RunSynchronously
    let deserialized = JsonConvert.DeserializeObject<Response<'response>>(response, serializerSettings)
    deserialized.Data

module GetCategory =
    // response types
    type VideoLink = { uri: string }
    type Videos = { links: VideoLink[] }
    type Player = { id: string }

    type Times =
      { /// this is in seconds
        primary_t: float }

    type Run2 =
      { id: string
        weblink: string
        game: string
        category: string
        videos: Videos
        players: Player[]
        date: string
        submitted: DateTime option
        times: Times }

    type Run = { place: int; run: Run2 }
    type CategoryResponse = { runs: Run[] }
    
    let getRankings (cat: SpeedrunningCategory) =
        let url =
            let categoryId = getCategoryId cat
            sprintf "%s/leaderboards/sm64/category/%s" baseUrl categoryId
            
        let response = makeRequest<CategoryResponse> url
        response
