namespace Stroodel

module Syntax =

    // In the original (Core) grammar, expressions=c and symbols=x
    type Symbol = string

    // Expressions:
    type Expr =
    | The of Expr * Expr    // Type annotation
    | Var of Symbol         // Variable reference
    | Atom                  // The Atom type
    | AtomLiteral of string // An 'atom-literal
    | Pair of Expr * Expr   // A Pair(B, C)
    | Lambda of Expr * Expr // A function
    | Nat                   // The Nat type
    | NatLiteral of int     // An acutal natural number
    | Zero                  // 0
    | ListType of Expr      // The List type
    | Trivial               // The Unit type
    | Sole                  // Unit constructor
    | Absurd                // The empty type
    | Nil                   // nil, an empty list

    // There also is toplevel syntax for declararations:
    type Declarations =
    | Claim
    | Define
