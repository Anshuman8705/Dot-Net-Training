using System;

// ==================================================================
// INTERFACE
// An interface only lists WHAT must be done, never HOW.
// Any class that "implements" it must write the actual method body.
// ==================================================================
interface IBill
{
    void GenerateBill(StationeryItem item, int purchaseQty, double discount);
}
