module SM64.Meta

/// Which release of SM64 are we talking about?
type GameRelease =
    | US
    // TODO: support others
    
type Cap = Wing | Metal | Vanish
type Key = BowserKey1 | UpstairsKey

type Obtainable =
    | Cap of Cap
    | Key of Key
