module Deck

open Domain

let generateFullCardDeckWithoutJoker : DeckType = 
    
    let systemArrayToArray (cardSuitSystemArray : System.Array, cardValueSystemArray : System.Array) = 
        let cardSuitArray = (Array.init cardSuitSystemArray.Length (fun index -> (cardSuitSystemArray.GetValue index) :?> CardSuitType))
        let cardValueArray = (Array.init cardValueSystemArray.Length (fun index -> (cardValueSystemArray.GetValue index) :?> CardValueType))

        (cardSuitArray, cardValueArray)
    
    let combineArrays (cardSuitTypeArray : CardSuitType array, cardValueTypeArray : CardValueType array) = 
        Array.map (fun cardSuitType -> 
            Array.map (fun cardValueType -> (cardSuitType, cardValueType)) cardValueTypeArray 
        ) cardSuitTypeArray
        |> Array.reduce Array.append
    
    let shuffleArray (array: 'a array) = 
        let random = System.Random()
        let randomIndex = fun _ ->  random.Next(Array.length array)

        let swapPosition  posA posB = 
            let aux = array.[posA]
            array.[posA] <- array.[posB]
            array.[posB] <- aux

        Array.iteri (fun index _ -> (swapPosition index (randomIndex()))) array 
        array

    ((System.Enum.GetValues(typeof<CardSuitType>)),  (System.Enum.GetValues(typeof<CardValueType>)))
    |> systemArrayToArray
    |> combineArrays
    |> shuffleArray
    |> Array.toList