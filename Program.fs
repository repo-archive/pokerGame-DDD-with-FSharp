// Learn more about F# at http://fsharp.org

open System
open Domain

open Deck

[<EntryPoint>]
let main argv =
    let deck = Deck.generateFullCardDeckWithoutJoker
    let (hand, newDeck) = (Option.get (Deck.giveCards deck 5))
    
    printfn "%A" hand

    0 // return an integer exit code
