namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private readonly string _seed;
        private readonly string _name;
        private readonly int _ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            _name = name;
            _ordinal = ordinal;
            _seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        public string Seed
        {
            get => _seed;
        }
        // TODO improve
        // public string GetSeed()
        // {
        //     return this.seed;
        // }

        public string Name
        {
            get => _name;
        }
        // TODO improve
        // public string GetName()
        // {
        //     return this.name;
        // }

        public int Ordinal
        {
            get => _ordinal;
        }
        // TODO improve
        // public int GetOrdinal()
        // {
        //     return this.ordinal;
        // }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            // TODO understand string interpolation
            return $"{GetType().Name}(Name={Name}, Seed={Seed}, Ordinal={Ordinal})";
        }

        // TODO generate Equals(object obj)
        public override bool Equals(object obj)
        {

            Card arg = (Card)obj;
            return arg != null && arg.Name == Name && arg.Seed == Seed && arg.Ordinal == Ordinal;
        }
        // TODO generate GetHashCode()
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Seed,Ordinal);
        }

        
    }
}
