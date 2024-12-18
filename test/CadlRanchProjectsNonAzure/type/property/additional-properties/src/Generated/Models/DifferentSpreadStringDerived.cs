// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    /// <summary> The DifferentSpreadStringDerived. </summary>
    public partial class DifferentSpreadStringDerived : DifferentSpreadStringRecord
    {
        /// <summary> Initializes a new instance of <see cref="DifferentSpreadStringDerived"/>. </summary>
        /// <param name="id"></param>
        /// <param name="derivedProp"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="derivedProp"/> is null. </exception>
        public DifferentSpreadStringDerived(float id, string derivedProp) : base(id)
        {
            Argument.AssertNotNull(derivedProp, nameof(derivedProp));

            DerivedProp = derivedProp;
        }

        /// <summary> Initializes a new instance of <see cref="DifferentSpreadStringDerived"/>. </summary>
        /// <param name="id"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="derivedProp"></param>
        internal DifferentSpreadStringDerived(float id, IDictionary<string, string> additionalProperties, IDictionary<string, BinaryData> serializedAdditionalRawData, string derivedProp) : base(id, additionalProperties, serializedAdditionalRawData)
        {
            DerivedProp = derivedProp;
        }

        /// <summary> Initializes a new instance of <see cref="DifferentSpreadStringDerived"/> for deserialization. </summary>
        internal DifferentSpreadStringDerived()
        {
        }

        /// <summary> Gets or sets the derived prop. </summary>
        public string DerivedProp { get; set; }
    }
}
