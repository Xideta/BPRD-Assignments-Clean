/*
Exercise 1.4 This chapter has shown how to represent abstract syntax in functional
languages such as F# (using algebraic datatypes) and in object-oriented languages
such as Java or C# (using a class hierarchy and composites).

(i) Use Java or C# classes and methods to do what we have done using the F#
datatype aexpr in the preceding exercises. Design a class hierarchy to repre-
sent arithmetic expressions: it could have an abstract class Expr with sub-
classes CstI, Var, and Binop, where the latter is itself abstract and has
concrete subclasses Add, Mul and Sub.All classes should implement the
toString() method to format an expression as a String.
The classes may be used to build an expression in abstract syntax, and then
print it, as follows:

    Expr e = new Add(new CstI(17), new Var("z"));
    System.out.println(e.toString());
*/