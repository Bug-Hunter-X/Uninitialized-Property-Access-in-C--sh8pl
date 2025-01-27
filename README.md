# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property before it has been explicitly initialized.  Uninitialized properties will have default values, but this can lead to unexpected behavior and difficult-to-debug issues.

The `bug.cs` file shows the erroneous code, while `bugSolution.cs` provides the corrected version.