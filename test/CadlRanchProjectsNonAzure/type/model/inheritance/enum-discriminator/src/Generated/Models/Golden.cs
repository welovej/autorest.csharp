// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.EnumDiscriminator.Models
{
    /// <summary> The Golden. </summary>
    public partial class Golden : Dog
    {
        /// <summary> Initializes a new instance of <see cref="Golden"/>. </summary>
        /// <param name="weight"></param>
        public Golden(int weight) : base(weight)
        {
            Kind = DogKind.Golden;
        }

        /// <summary> Initializes a new instance of <see cref="Golden"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="weight"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Golden(DogKind kind, int weight, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, weight, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="Golden"/> for deserialization. </summary>
        internal Golden()
        {
        }
    }
}
