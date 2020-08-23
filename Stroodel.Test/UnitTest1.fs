module Stroodel.Test

open NUnit.Framework
open Syntax
open TypeChecker

[<SetUp>]
let Setup () =
    ()

[<Test>]
let TestAtoms () =
    let code = "'quiche-deluxe"
    let expr = TypeChecker.parse code
    Assert.That(expr, Is.EqualTo (AtomLiteral "'quiche-deluxe"))
    // TODO: let t = TypeChecker.check code
    // TODO: Assert.That(t, Is.EqualTo "(the Atom ''quiche-deluxe)")

[<Test>]
[<Ignore("Not yet implemented")>]
let TestTrivialTypes () =
    let code = "sole"
    let t = TypeChecker.parse code
    Assert.That(t, Is.EqualTo "(the Trivial sole)")
