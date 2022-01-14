module SM64.Core.Movement

open System

type MarioAction =
    | SingleJump // single "a"
    | DoubleJump // a subsequent "a" shortly after landing from a single jump
    | TripleJump // a subsequent "a" shortly after landing from a double jump
    | GroundPound  // "z" while suspended and in [some other state]
    | WallKick // "a" as you're jumping and make contact w/ a wall
    | SideFlip //  "a" while pivoting on the ground
    | Punch // single B
    | Kick // multiple B
    | BackFlip // "a" while crouched
    | GrabLedge
    | QuickLetGoOfLedge // A
    | SlowLetGoOfLedge // "up"
    | GrabOwl
    | Dive
    //| LavaBurn. (commented because keeping this 'basic' for now)
    
type MarioMovement =
    | Movement
    | Neutral
    | Walking // should walking/running combined? need to study further.
    | Running

type MarioHealth =
    Full | Seven | Six | Five | Four | Three | Two | One | Dead

type MarioState =
    MarioMovement * MarioHealth
     // and some other stuff (e.g. "in the air?")
    
// todo: experiment in defining a state graph (e.g. illegal to go from Dive to GroundPound)

let isActionLegal (currentState: MarioState) (attemptedAction: MarioAction) =
    match currentState, attemptedAction with
    | _ -> 
        NotImplementedException("TODO")
        |> raise