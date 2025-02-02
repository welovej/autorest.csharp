// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Client.Structure.Service.Models;
using NUnit.Framework;

namespace Client.Structure.Service.Samples
{
    public partial class Samples_Bar
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Bar_Five_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = client.Five();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Bar_Five_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = await client.FiveAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Bar_Five_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = client.Five();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Bar_Five_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = await client.FiveAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Bar_Six_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = client.Six();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Bar_Six_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = await client.SixAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Bar_Six_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = client.Six();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Bar_Six_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Bar client = new ServiceClient(endpoint, default).GetBarClient();

            Response response = await client.SixAsync();

            Console.WriteLine(response.Status);
        }
    }
}
