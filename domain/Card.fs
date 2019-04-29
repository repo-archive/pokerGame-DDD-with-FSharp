namespace Domain

type CardSuitType = Diamonds | Clubs | Hearts | Spades
type CardValueType = Ace | Deuce | Trey | Four | Five | Six | Seven | Eight | Nine | Ten | Jack | Queen | King

type CardType = CardValueType * CardSuitType

module Card = 
    let valueOf(card) = 
        match card with
        | (Deuce, _) -> 2 
        | (Trey, _) -> 3
        | (Four, _) -> 4
        | (Five, _) -> 5
        | (Six, _) -> 6
        | (Seven, _) -> 7
        | (Eight, _) -> 8
        | (Nine, _) -> 9
        | (Ten, _) -> 10
        | (Jack, _) -> 11
        | (Queen, _) -> 12
        | (King, _) -> 13
        | (Ace, _) -> 14

    let biggerThan cardA cardB = valueOf cardA > valueOf cardB