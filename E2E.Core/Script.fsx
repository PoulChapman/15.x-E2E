// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open E2E.Core

// Define your library scripting code here

let mutable value = 12

printfn "Value is: %d" value

value <- 13

printfn "Value is now: %d" value
