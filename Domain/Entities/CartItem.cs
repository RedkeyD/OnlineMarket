﻿namespace Domain.Entities;

public class CartItem
{
    public Guid Id { get; }
    public Guid CartId { get; }
    public Guid ProductId { get; }
    public int Quantity { get; private set; }
    public Cart ShoppingCart { get; private set; }
    public Product Product { get; private set; }

    public CartItem( Guid cartId, Guid productId, int quantity )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        Id = Guid.NewGuid();
        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
    }

    public void SetQuantity( int quantity )
    {
        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        Quantity = quantity;
    }
}
