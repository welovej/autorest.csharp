// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary> The Goose. </summary>
    public partial class Goose : Bird
    {
        /// <summary> Initializes a new instance of <see cref="Goose"/>. </summary>
        /// <param name="wingspan"></param>
        public Goose(int wingspan) : base(wingspan)
        {
            Kind = "goose";
        }

        /// <summary> Initializes a new instance of <see cref="Goose"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="wingspan"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Goose(string kind, int wingspan, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, wingspan, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="Goose"/> for deserialization. </summary>
        internal Goose()
        {
        }
    }
}
