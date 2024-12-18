// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary> The Sparrow. </summary>
    public partial class Sparrow : Bird
    {
        /// <summary> Initializes a new instance of <see cref="Sparrow"/>. </summary>
        /// <param name="wingspan"></param>
        public Sparrow(int wingspan) : base(wingspan)
        {
            Kind = "sparrow";
        }

        /// <summary> Initializes a new instance of <see cref="Sparrow"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="wingspan"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Sparrow(string kind, int wingspan, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, wingspan, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="Sparrow"/> for deserialization. </summary>
        internal Sparrow()
        {
        }
    }
}
