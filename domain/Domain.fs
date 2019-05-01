namespace Domain

type CardSuitType = Diamonds=0 | Clubs=1 | Hearts=2 | Spades=3
type CardValueType = Ace=14 | Deuce=2 | Trey=3 | Four=4 | Five=5 | Six=6 | Seven=7 | Eight=8 | Nine=9 | Ten=10 | Jack=11 | Queen=12 | King=13

type CardType = CardValueType * CardSuitType

type DeckType = CardType list

type HandType = CardType list

type PlayerType = { name : string; hand: HandType }

type GameType = { players : PlayerType list; deck : DeckType }