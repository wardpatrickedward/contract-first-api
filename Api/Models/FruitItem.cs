namespace Api.Models
{
    /// <summary>
    /// Represents a single fruit line item within an order.
    /// </summary>
    /// <param name="Fruit">The name of the fruit.</param>
    /// <param name="Quantity">The requested quantity for this fruit.</param>
    internal record FruitItem(string Fruit, int Quantity)
    {
        /// <summary>
        /// Parameterless constructor for model binding.
        /// </summary>
        public FruitItem() : this(string.Empty, 0) { }
    }
}
