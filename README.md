# F# Mutable Variable Scope Issue

This example demonstrates a common issue in F# related to mutable variables and function scope.  When attempting to swap two mutable variables using a function, the changes made inside the function are not reflected outside its scope unless explicitly returned.

The `bug.fs` file contains code that incorrectly attempts to swap variables. The `bugSolution.fs` file demonstrates the corrected approach.

## How to Reproduce

1. Compile and run `bug.fs`.
2. Observe that the values of x, y, and z remain unchanged after calling the `swap` function.
3. Compile and run `bugSolution.fs` to see the corrected behavior.

## Explanation

F# functions, by default, operate on copies of the input variables unless those variables are declared as mutable and explicitly passed by reference (which is generally discouraged in favor of returning new values).

The solution involves returning the swapped values from the function and reassigning them to the original variables.