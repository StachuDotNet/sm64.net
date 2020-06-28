module SM64.Core.Movement

open System

type MarioAction =
    | SingleJump
    | DoubleJump
    | TripeJump
    | GroundPound
    | WallKick
    | SideFlip
    | Punch // single B
    | Kick // multiple B
    | BackFlip
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
    
// todo: experiment in defining a state graph (e.g. illegal to go from Dive to GroundPound

let isActionLegal (currentState: MarioState) (attemptedAction: MarioAction) =
    match currentState, attemptedAction with
    | _ -> 
        NotImplementedException("TODO")
        |> raise