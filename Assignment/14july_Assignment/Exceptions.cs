using System;

// ==================================================================
// Custom Exceptions
// Each class below represents one specific error situation.
// We inherit from "Exception" so they behave like normal C# exceptions,
// but with a name that tells us exactly what went wrong.
// ==================================================================

class LoginFailedException : Exception
{
    public LoginFailedException(string message) : base(message) { }
}

class InvalidPriceException : Exception
{
    public InvalidPriceException(string message) : base(message) { }
}

class InvalidQuantityException : Exception
{
    public InvalidQuantityException(string message) : base(message) { }
}

class DuplicateItemException : Exception
{
    public DuplicateItemException(string message) : base(message) { }
}

class ItemNotFoundException : Exception
{
    public ItemNotFoundException(string message) : base(message) { }
}

class InsufficientStockException : Exception
{
    public InsufficientStockException(string message) : base(message) { }
}
