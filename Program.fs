// Learn more about F# at http://fsharp.org

open System
open Domain

[<EntryPoint>]
let main argv =
    let cardA = CardType(CardValueType.King, CardSuitType.Spades)
    let cardB = CardType(CardValueType.Ace, CardSuitType.Spades)
    let result = (Card.biggerThan cardB cardA)

    printfn "%A" result
    0 // return an integer exit code
