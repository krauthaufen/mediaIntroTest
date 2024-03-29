namespace Yeah.Model

open System
open Aardvark.Base
open Aardvark.Base.Incremental
open Aardvark.UI.Primitives

type Primitive =
    | Box
    | Sphere


[<DomainType>]
type Model =
    {
        count : int
        currentModel    : Primitive
        cameraState     : CameraControllerState
    }