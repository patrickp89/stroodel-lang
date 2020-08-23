namespace Stroodel

module TypeChecker =
    open System
    open FSharp.Text.Lexing
    open Parser
    open Lexer

    let parse code =
        let lexbuf = LexBuffer<char>.FromString code
        let expr = Parser.start Lexer.tokenstream lexbuf
        printfn "there are %A tokens" expr
        expr

    let check code =
        let t = parse code
        // TODO: ...
        "TODO"
