namespace Api.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the payload required to create a new fruit order.
    /// </summary>
    /// <param name="CustomerName">Name of the customer placing the order.</param>
    /// <param name="Items">Collection of <see cref="FruitItem"/> representing the requested items.</param>
    internal record NewFruitOrder(string CustomerName, List<FruitItem> Items)
    {
        /// <summary>
        /// Parameterless constructor for model binding and serialization.
        /// </summary>
        public NewFruitOrder() : this(string.Empty, new List<FruitItem>()) { }
    }
}
