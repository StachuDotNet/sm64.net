module SM64.Net.Views.Tools.TwitchBot

open Feliz.ViewEngine

let view =
    Html.div [
        Html.p "Twitch bot that integrates with speedrun.com. Plans exist to further integrate with Twitch, other APIs, and sm64.net-hosted data"
        
        Html.p "Commands supported:"
        Html.ul [
            Html.li [
                Html.code "!sm64 wr 0"
                Html.p "Returns the current WR for the given category"
                Html.p "Also works for 1, 16, 70, 120"
            ]
            Html.li [
                Html.code "!sm64"
                Html.p "Provides a link to this documentation page"
            ]
            Html.li [
                Html.code "!sm64 suggest ..."
                Html.p "Your suggestion will be logged, I review the suggestions once in a while"
            ]
        ]
        
        Html.p "If you'd like to have the bot join your chat, contact me (Stachu) on Twitter (@stachudotnet) or Discord (StachuDotNet#9760)"
    ]
