// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.NewProject.TypeSpec.Models
{
    /// <summary> The FloatExtensibleEnum. </summary>
    public readonly partial struct FloatExtensibleEnum : IEquatable<FloatExtensibleEnum>
    {
        private readonly float _value;

        /// <summary> Initializes a new instance of <see cref="FloatExtensibleEnum"/>. </summary>
        public FloatExtensibleEnum(float value)
        {
            _value = value;
        }

        private const float OneValue = 1F;
        private const float TwoValue = 2F;
        private const float FourValue = 4F;

        /// <summary> 1. </summary>
        public static FloatExtensibleEnum One { get; } = new FloatExtensibleEnum(OneValue);
        /// <summary> 2. </summary>
        public static FloatExtensibleEnum Two { get; } = new FloatExtensibleEnum(TwoValue);
        /// <summary> 4. </summary>
        public static FloatExtensibleEnum Four { get; } = new FloatExtensibleEnum(FourValue);

        internal float ToSerialSingle() => _value;

        /// <summary> Determines if two <see cref="FloatExtensibleEnum"/> values are the same. </summary>
        public static bool operator ==(FloatExtensibleEnum left, FloatExtensibleEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FloatExtensibleEnum"/> values are not the same. </summary>
        public static bool operator !=(FloatExtensibleEnum left, FloatExtensibleEnum right) => !left.Equals(right);
        /// <summary> Converts a <see cref="float"/> to a <see cref="FloatExtensibleEnum"/>. </summary>
        public static implicit operator FloatExtensibleEnum(float value) => new FloatExtensibleEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FloatExtensibleEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FloatExtensibleEnum other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
