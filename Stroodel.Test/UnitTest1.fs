module Stroodel.Test

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    let b = true
    Assert.That(b, Is.EqualTo true)
