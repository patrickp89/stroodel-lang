namespace Stroodel

module TypeChecker =
    open System
    open FSharp.Text.Lexing
    open Parser
    open Lexer
    open Util

    let printError (lexbuf: LexBuffer<char>) (e: System.Exception) =
        match info lexbuf with
        | UNKNOWN -> "ParseError: " + (e.ToString())
        | Info.FI(_, l, c) -> "ParseError at line " + (string l) + " , offset " + (string c) + ": " + (e.ToString())

    let parse code =
        let lexbuf = LexBuffer<char>.FromString code
        try
            let expr = Parser.start Lexer.tokenstream lexbuf
            printfn "there are %A tokens" expr
            Ok expr
        with
        | e -> Error (printError lexbuf e)

    let check code =
        let t = parse code
        "TODO"
