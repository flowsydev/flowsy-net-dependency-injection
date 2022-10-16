# Flowsy Dependency Injection

Basic dependency injection functionality for Flowsy-based projects.

## Service Tags
The **ServiceTag** attribute can be used to create multiple classes implementing
the same interface and tag each one with a different identifier.

When the application requires an implementation of that interface, the **GetTaggedService**
extension method can be invoked on **IServiceProvider** to get an instance tagged with
a specific identifier.
