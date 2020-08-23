namespace Stroodel

module Syntax =

    // In the original (Core) grammar, expressions=c and symbols=x
    type Symbol = string

    type Expr =
    | VariableReference of Symbol
    | AtomType
    | AtomLiteral of string
