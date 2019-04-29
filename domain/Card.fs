namespace Domain

type CardSuitType = Diamonds | Clubs | Hearts | Spades
type CardValueType = Ace | Deuce | Trey | Four | Five | Six | Seven | Eight | Nine | Ten | Jack | Queen | King

type CardType = CardValueType * CardSuitType