using System;

namespace Candlekeep.Utils.Testability
{
    /// <summary>
    /// Base class for builders of test object instances.
    /// </summary>
    public abstract class BuilderBase
    {
        /// <summary>
        /// Gets the random generator this builder uses when creating test data.
        /// </summary>
        public Random Random { get; }

        protected BuilderBase()
        {
            Random = new Random();
        }
    }
}