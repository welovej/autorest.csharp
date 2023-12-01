// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace constants.Models
{
    /// <summary> The NoModelAsStringRequiredOneValueDefault. </summary>
    internal partial class NoModelAsStringRequiredOneValueDefault
    {
        /// <summary> Initializes a new instance of <see cref="NoModelAsStringRequiredOneValueDefault"/>. </summary>
        internal NoModelAsStringRequiredOneValueDefault()
        {
            Parameter = NoModelAsStringRequiredOneValueDefaultEnum.Value1;
        }

        /// <summary> Initializes a new instance of <see cref="NoModelAsStringRequiredOneValueDefault"/>. </summary>
        /// <param name="parameter"></param>
        internal NoModelAsStringRequiredOneValueDefault(NoModelAsStringRequiredOneValueDefaultEnum parameter)
        {
            Parameter = parameter;
        }

        /// <summary> Gets the parameter. </summary>
        public NoModelAsStringRequiredOneValueDefaultEnum Parameter { get; }
    }
}
