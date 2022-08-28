module SM64.Meta

type Cap = Wing | Metal | Vanish

type Key = BowserKey1 | UpstairsKey

// Do we really need this nesting? hmm

type Obtainable =
    | Cap of Cap
    | Key of Key
    
type Toad =
    | HMCToad
    | UpstairsToad
    | TippyToad
