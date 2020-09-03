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
let TestSingleDigitNaturalNumbers () =
    let one = "1"
    let expr = TypeChecker.parse one
    Assert.That(expr, Is.EqualTo (Nat 1))
    // TODO: let t = TypeChecker.check one
    // TODO: Assert.That(t, Is.EqualTo "(the Nat 1)")

[<Test>]
let TestSpecialNaturalNumbers () =
    let zero = "zero"
    let actExpr = TypeChecker.parse zero
    let expExpr = Zero
    Assert.That(actExpr, Is.EqualTo expExpr)
    // TODO: let expType = "(the Nat 0)" // TODO: what is the "normalzied" version? Zero or Nat 0?
    // TODO: let actType = TypeChecker.check zero
    // TODO: Assert.That(actType, Is.EqualTo expType)

[<Test>]
let TestMultiDigitNaturalNumbers () =
    let one = "16"
    let expr = TypeChecker.parse one
    Assert.That(expr, Is.EqualTo (Nat 16))
    // TODO: let t = TypeChecker.check one
    // TODO: Assert.That(t, Is.EqualTo "(the Nat 16)")

[<Test>]
[<Ignore("Not yet implemented")>]
let TestPairs () =
    let code =
        "(the (Pair Atom Atom)" +
        "  (cons 'foo 'bar))"
    let expr = TypeChecker.parse code
    Assert.That(expr, Is.EqualTo (Pair ((AtomLiteral "foo"), (AtomLiteral "bar"))))
    // TODO: let t = TypeChecker.check code
    // TODO: Assert.That(t, Is.EqualTo "(the (Pair Atom Atom) (cons 'foo 'bar))")

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

[<Test>]
[<Ignore("Not yet implemented")>]
let TestFunctionTypes () =
    let code =
        "(the (Π ((a Atom))" +
        "       (Pair Atom Atom))" +
        "  (λ (flavor)" +
        "    (cons flavor 'lentils)))"
    let expr = TypeChecker.parse code
    Assert.That(expr, Is.EqualTo (AtomLiteral "'TODO"))
    // TODO: let t = TypeChecker.check code ...
