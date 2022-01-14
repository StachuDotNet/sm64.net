module SM64.Utils.SimpleCache

open System
open Microsoft.Extensions.Caching.Memory
            
let makeCache<'key, 'value> (expirationDurationMinutes: float) (f: 'key -> 'value) =
    let cache =
        let options = MemoryCacheOptions()
        new MemoryCache(options)

    let makeKey = sprintf "%O"  // todo: maybe pass in a fn to stringify 'key'
    let _cacheLock = Object()

    let set (key: 'key) (v: 'value): unit =
        let key = makeKey key

        lock _cacheLock (fun () ->
            let expiration = DateTimeOffset.Now.AddMinutes expirationDurationMinutes
            cache.Set(key, v, expiration) |> ignore
        )
        
    fun (k: 'key) ->
        lock _cacheLock (fun () ->
            let item = makeKey k |> cache.Get

            match item with
            | null ->
                let v = f k
                set k v
                v
            | v -> v :?> 'value
        )
