using System;

// ==================================================================
// ABSTRACTION
// "abstract" means we can never do "new Product()" directly.
// It only exists so that other classes can inherit from it and
// are FORCED to write their own CalculateDiscount() method.
// ==================================================================
abstract class Product
{
    // No body here - just a rule that every child class must follow.
    public abstract double CalculateDiscount();
}
