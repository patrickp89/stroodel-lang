module Stroodel.Test

open NUnit.Framework
open Syntax
open TypeChecker

[<SetUp>]
let Setup () =
    ()

let parseCode code expExpr =
    match TypeChecker.parse code with
    | Ok expr -> Assert.That(expr, Is.EqualTo expExpr)
    | Error e -> Assert.Fail(e)

[<Test>]
let TestAtoms () =
    let code = "'quiche-deluxe"
    parseCode code (AtomLiteral "'quiche-deluxe")
    // TODO: let t = TypeChecker.check code
    // TODO: Assert.That(t, Is.EqualTo "(the Atom ''quiche-deluxe)")

[<Test>]
let TestTrivialTypes () =
    let code = "sole"
    parseCode code (Sole)
    // TODO: let t = TypeChecker.check code
    // TODO: Assert.That(t, Is.EqualTo "(the Trivial sole)")

[<Test>]
let TestSingleDigitNaturalNumbers () =
    let one = "1"
    parseCode one (NatLiteral 1)
    // TODO: let t = TypeChecker.check one
    // TODO: Assert.That(t, Is.EqualTo "(the Nat 1)")

[<Test>]
let TestSpecialNaturalNumbers () =
    let zero = "zero"
    parseCode zero Zero
    // TODO: let expType = "(the Nat 0)" // TODO: what is the "normalzied" version? Zero or Nat 0?
    // TODO: let actType = TypeChecker.check zero
    // TODO: Assert.That(actType, Is.EqualTo expType)

[<Test>]
let TestMultiDigitNaturalNumbers () =
    let number = "16"
    parseCode number (NatLiteral 16)
    // TODO: let t = TypeChecker.check one
    // TODO: Assert.That(t, Is.EqualTo "(the Nat 16)")

[<Test>]
let TestPairs () =
    let pairUniverseCode = "(Pair Atom Atom)"
    parseCode pairUniverseCode (Pair (Atom, Atom))
    // TODO: let pairUniverseType = TypeChecker.check pairUniverseCode
    // TODO: Assert.That(pairUniverseType, Is.EqualTo "(the U (Pair Atom Atom))")
    let code =
        "(the (Pair Atom Atom)\
          (cons 'foo 'bar))"
    let expExpr =
        The (Pair (Atom, Atom),
            Cons (AtomLiteral "'foo", AtomLiteral "'bar"))
    parseCode code expExpr
    // TODO: let t = TypeChecker.check code
    // TODO: Assert.That(t, Is.EqualTo "(the (Pair Atom Atom) (cons 'foo 'bar))")

[<Test>]
let TestSimpleTypeAnnotations () =
    let nilNatListCode =
        "(the (List Nat)" +
        "    nil)"
    parseCode nilNatListCode (The ((ListType Nat), Nil))
    // TODO: let nilNatListType = TypeChecker.check nilNatListCode
    // TODO: Assert.That(nilNatListType, Is.EqualTo nilNatListCode) // yes, the type annotation is already correct!

[<Test>]
[<Ignore("Not yet implemented")>]
let TestAbsurdTypes () =
    let code =
        "(the (→ Absurd" +
        "         Nat)" +
        "  (λ (nope)" +
        "    (ind-Absurd nope Nat)))"
    parseCode code (AtomLiteral "'TODO")
    // TODO: let t = TypeChecker.check code ...

[<Test>]
[<Ignore("Not yet implemented")>]
let TestFunctionTypes () =
    let code =
        "(the (Π ((a Atom))" +
        "       (Pair Atom Atom))" +
        "  (λ (flavor)" +
        "    (cons flavor 'lentils)))"
    parseCode code (AtomLiteral "'TODO")
    // TODO: let t = TypeChecker.check code ...
