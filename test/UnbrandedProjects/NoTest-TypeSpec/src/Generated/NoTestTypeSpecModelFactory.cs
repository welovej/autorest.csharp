// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace NoTestTypeSpec.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class NoTestTypeSpecModelFactory
    {
        /// <summary> Initializes a new instance of Thing. </summary>
        /// <param name="name"> name of the Thing. </param>
        /// <param name="requiredUnion"> required Union. </param>
        /// <param name="requiredLiteralString"> required literal string. </param>
        /// <param name="requiredLiteralInt"> required literal int. </param>
        /// <param name="requiredLiteralFloat"> required literal float. </param>
        /// <param name="requiredLiteralBool"> required literal bool. </param>
        /// <param name="optionalLiteralString"> optional literal string. </param>
        /// <param name="optionalLiteralInt"> optional literal int. </param>
        /// <param name="optionalLiteralFloat"> optional literal float. </param>
        /// <param name="optionalLiteralBool"> optional literal bool. </param>
        /// <param name="requiredBadDescription"> description with xml &lt;|endoftext|&gt;. </param>
        /// <param name="optionalNullableList"> optional nullable collection. </param>
        /// <param name="requiredNullableList"> required nullable collection. </param>
        /// <returns> A new <see cref="Models.Thing"/> instance for mocking. </returns>
        public static Thing Thing(string name = null, BinaryData requiredUnion = null, ThingRequiredLiteralString requiredLiteralString = default, ThingRequiredLiteralInt requiredLiteralInt = default, ThingRequiredLiteralFloat requiredLiteralFloat = default, bool requiredLiteralBool = default, ThingOptionalLiteralString? optionalLiteralString = null, ThingOptionalLiteralInt? optionalLiteralInt = null, ThingOptionalLiteralFloat? optionalLiteralFloat = null, bool? optionalLiteralBool = null, string requiredBadDescription = null, IEnumerable<int> optionalNullableList = null, IEnumerable<int> requiredNullableList = null)
        {
            optionalNullableList ??= new List<int>();
            requiredNullableList ??= new List<int>();

            return new Thing(name, requiredUnion, requiredLiteralString, requiredLiteralInt, requiredLiteralFloat, requiredLiteralBool, optionalLiteralString, optionalLiteralInt, optionalLiteralFloat, optionalLiteralBool, requiredBadDescription, optionalNullableList?.ToList(), requiredNullableList?.ToList());
        }
    }
}
