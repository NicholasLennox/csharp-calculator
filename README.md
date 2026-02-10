# Basic 'class' demo

This application builds a simple calculator in an OOP manner. 

It will explore:

- Object construction
- Fields and properties (to track internal state)
- Methods (perform operations and manipulate internal state)
- Basic documentation

Additionally, the following constructs will be used to create an interactive application:

- loops
- if statements

## Fields vs properties (and why we care)

This calculator keeps *state* - values it remembers between method calls.

### Fields
A field is raw storage. We usually keep fields **private** so outside code cannot directly change our internal state.

If a field were public, any code could do this:

```csharp
calc.LastResult = -999;
```

That breaks encapsulation (the object no longer controls its own state).

### Properties

A property is a controlled doorway into state.
We can decide:

* can it be read?
* can it be written?
* should we validate input?
* should we format the output?
* should it be computed from other values?

### Auto-properties (compiler creates the backing field)

```csharp
public int LastResult { get; private set; }
```

This is shorthand for “a private field + a public property”.
C# generates the hidden field for us.

The `private set` means:

* other code can read `LastResult`
* only this class can change it

### Computed properties (no backing field)

```csharp
public int DoubleLastResult => LastResult * 2;
```

This does not store anything.
Each time you access it, the expression runs again.

### Expression-bodied members (`=>`)

In these examples, `=>` means “return this expression”.

For example:

```csharp
public int DoubleLastResult => LastResult * 2;
```

is equivalent to:

```csharp
public int DoubleLastResult
{
    get { return LastResult * 2; }
}
```

### Custom access (backing field pattern)

Sometimes we want a property to do more than just store a value.
In that case we often keep the stored value in a private field and expose a property as the public doorway.

