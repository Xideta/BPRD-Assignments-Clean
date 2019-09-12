

open System
open Parse
open Absyn


[<EntryPoint>]
let main argv =
    
    try
        printfn "%A" (fromString "1 + 2 * 3")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "1 - 2 - 3")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "1 + -2")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "x++")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "1 + 1.2")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "1 + ")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "let z = (17) in z + 2 * 3 end")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "let z = 17) in z + 2 * 3 end")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "let in = (17) in z + 2 * 3 end")
    with
        | :? System.Exception -> printfn "Error parsing input"
    try
        printfn "%A" (fromString "1 + let x=5 in let y=7+x in y+y end + x end")
    with
        | :? System.Exception -> printfn "Error parsing input"
    
    0