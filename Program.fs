// Learn more about F# at http://fsharp.org

open System
open Domain

[<EntryPoint>]
let main argv =
    let x = CardType(CardValueType.Ace, CardSuitType.Spades)
    printfn "%A" x
    0 // return an integer exit code
