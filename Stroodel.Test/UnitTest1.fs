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
let TestTrivialTypes () =
    let code = "sole"
    let expr = TypeChecker.parse code
    Assert.That(expr, Is.EqualTo (Sole))
    // TODO: let t = TypeChecker.check code
    // TODO: Assert.That(t, Is.EqualTo "(the Trivial sole)")

[<Test>]
let TestNaturalNumbers () =
    let one = "1"
    let expr = TypeChecker.parse one
    Assert.That(expr, Is.EqualTo (Nat 1))
    // TODO: let t = TypeChecker.check one
    // TODO: Assert.That(t, Is.EqualTo "(the Trivial sole)")
    let zero = "zero"
    let actExpr = TypeChecker.parse zero
    let expExpr = Zero
    Assert.That(actExpr, Is.EqualTo expExpr)
    // TODO: let expType = "(the Nat 0)"
    // TODO: let actType = TypeChecker.check zero
    // TODO: Assert.That(actType, Is.EqualTo expType)

[<Test>]
[<Ignore("Not yet implemented")>]
let TestAbsurdTypes () =
    let code =
        "(the (→ Absurd" +
        "         Nat)" +
        "  (λ (nope)" +
        "    (ind-Absurd nope Nat)))"
    let expr = TypeChecker.parse code
    Assert.That(expr, Is.EqualTo (AtomLiteral "'TODO"))
    // TODO: let t = TypeChecker.check code ...
