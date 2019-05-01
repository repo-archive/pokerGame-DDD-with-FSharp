// Learn more about F# at http://fsharp.org

open System
open Domain

[<EntryPoint>]
let main argv =
    let cardA = CardType(CardValueType.King, CardSuitType.Spades)
    let cardB = CardType(CardValueType.Ace, CardSuitType.Spades)

    printfn "%A" (Card.biggerThan cardA cardB)
    printfn "%A" (Card.biggerThan cardB cardA)
    
    0 // return an integer exit code
