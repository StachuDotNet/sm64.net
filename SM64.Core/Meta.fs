module SM64.Meta

type Cap = Wing | Metal | Vanish

type Key = BowserKey1 | UpstairsKey

type Obtainable =
    | Cap of Cap
    | Key of Key
    
type Toad =
    | HMCToad
    | UpstairsToad
    | TippyToad
