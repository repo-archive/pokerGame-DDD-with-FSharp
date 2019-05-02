// Learn more about F# at http://fsharp.org

open System
open Domain

open Deck

[<EntryPoint>]
let main argv =
    printfn "%A" Deck.generateFullCardDeckWithoutJoker

    0 // return an integer exit code
