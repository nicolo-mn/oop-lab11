namespace Properties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A factory class for building <see cref="ISet{T}">decks</see> of <see cref="Card"/>s.
    /// </summary>
    public class DeckFactory
    {
        private string[] _seeds;

        private string[] _names;

        // TODO improve

        public IList<string> Seeds
        {
            get => _seeds.ToList();

            set => _seeds = value.ToArray();
        }
        // public  GetSeeds()
        // {
        //     return _seeds.ToList();
        // }

        // // TODO improve
        // public void SetSeeds(IList<string> seeds)
        // {
        //     _seeds = seeds.ToArray();
        // }


        public IList<string> Names
        {
            get => _names.ToList();

            set => _names = value.ToArray();
        }
        // TODO improve
        // public IList<string> GetNames()
        // {
        //     return _names.ToList();
        // }

        // // TODO improve
        // public void SetNames(IList<string> names)
        // {
        //     _names = names.ToArray();
        // }

        public int DeckSize
        {
            get => _names.Length * _seeds.Length;
        }

        // TODO improve
        // public int GetDeckSize()
        // {
        //     return _names.Length * _seeds.Length;
        // }

        public ISet<Card> Deck
        {
            get 
            {
                if (_names == null || _seeds == null)
                {
                    throw new InvalidOperationException();
                }

                return new HashSet<Card>(Enumerable
                    .Range(0, _names.Length)
                    .SelectMany(i => Enumerable
                        .Repeat(i, _seeds.Length)
                        .Zip(
                            Enumerable.Range(0, _seeds.Length),
                            (n, s) => Tuple.Create(_names[n], _seeds[s], n)))
                    .Select(tuple => new Card(tuple))
                    .ToList()); 
            }
        }
        /// TODO improve
        // public ISet<Card> GetDeck()
        // {
        //     if (_names == null || _seeds == null)
        //     {
        //         throw new InvalidOperationException();
        //     }

        //     return new HashSet<Card>(Enumerable
        //         .Range(0, _names.Length)
        //         .SelectMany(i => Enumerable
        //             .Repeat(i, _seeds.Length)
        //             .Zip(
        //                 Enumerable.Range(0, _seeds.Length),
        //                 (n, s) => Tuple.Create(_names[n], _seeds[s], n)))
        //         .Select(tuple => new Card(tuple))
        //         .ToList());
        // }
    }
}
