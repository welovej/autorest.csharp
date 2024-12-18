// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.NotDiscriminated.Models
{
    /// <summary> The Cat. </summary>
    public partial class Cat : Pet
    {
        /// <summary> Initializes a new instance of <see cref="Cat"/>. </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Cat(string name, int age) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Age = age;
        }

        /// <summary> Initializes a new instance of <see cref="Cat"/>. </summary>
        /// <param name="name"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="age"></param>
        internal Cat(string name, IDictionary<string, BinaryData> serializedAdditionalRawData, int age) : base(name, serializedAdditionalRawData)
        {
            Age = age;
        }

        /// <summary> Initializes a new instance of <see cref="Cat"/> for deserialization. </summary>
        internal Cat()
        {
        }

        /// <summary> Gets or sets the age. </summary>
        public int Age { get; set; }
    }
}
