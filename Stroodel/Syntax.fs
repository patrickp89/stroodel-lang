namespace Stroodel

module Syntax =

    // In the original (Core) grammar, expressions=c and symbols=x
    type Symbol = string

    // Expressions:
    type Expr =
    | The of Expr * Expr    // Type annotation
    | Var of Symbol         // Variable reference
    | Atom                  // Atom type
    | AtomLiteral of string // An 'atom-literal
    | Lambda of Expr * Expr // A function
    | Nat of int            // Natural number type
    | Zero                  // 0
    | Trivial               // Unit type
    | Sole                  // Unit constructor
    | Absurd                // Empty type

    // There also is toplevel syntax for declararations:
    type Declarations =
    | Claim
    | Define
