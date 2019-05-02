module Game

open Domain

let bigBang =
    { GameType.players = List.empty; GameType.deck = Deck.generateFullCardDeckWithoutJoker }

let addPlayer (game : GameType) (playerName : string) : GameType = 
    let newPlayer = { PlayerType.name = playerName; PlayerType.hand = List.empty }
    {game with players = newPlayer :: game.players }

let recallCards (game : GameType) : GameType = 
    { game with deck = Deck.generateFullCardDeckWithoutJoker; players = (List.map (fun player -> { player with hand = List.empty }) game.players)}

let dealCards (game : GameType) (cardsPerPlayer : int) : GameType = 
    // give card to a player and return a new player with hand, e the rest of the deck
    let giveCard player deck  = 
        let (hand, newDeck) = Option.get (Deck.giveCards deck cardsPerPlayer)
        ({player with hand = hand}, newDeck)
    
    // give card to each player and return the list of players and the rest of the deck to each iteration
    let itPlayers acc player = 
        let cardResult = (giveCard player (snd acc))
        let newPlayer = fst cardResult
        let newDeck = snd cardResult

        ((newPlayer :: fst acc), newDeck)

    let players, deck = List.fold itPlayers (List.empty, game.deck) game.players

    { GameType.players = players; GameType.deck = deck }