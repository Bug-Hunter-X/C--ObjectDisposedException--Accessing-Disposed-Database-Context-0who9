# C# ObjectDisposedException: Accessing Disposed Database Context

This repository demonstrates a common error in C# applications: attempting to access an object after it has been disposed.  Specifically, this example shows how accessing a database context after it's been disposed by the `using` statement results in an `ObjectDisposedException`.

## The Problem

The `bug.cs` file contains code that uses a database context within a `using` block.  After the `using` block completes, the context is automatically disposed.  However, the code attempts to access the context again *after* disposal, causing the exception.

## The Solution

The `bugSolution.cs` file presents a corrected version.  It ensures that all database operations are performed within the scope of the `using` block, preventing the `ObjectDisposedException`.