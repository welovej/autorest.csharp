// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Property.Optionality;
using _Type.Property.Optionality.Models;

namespace _Type.Property.Optionality.Samples
{
    public partial class Samples_CollectionsModel
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetAll_ShortVersion()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetAll_ShortVersion_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetAll_ShortVersion_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetAll_ShortVersion_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetAll_AllParameters()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetAll_AllParameters_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetAll_AllParameters_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetAll_AllParameters_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetDefault_ShortVersion()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetDefault_ShortVersion_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetDefault_ShortVersion_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetDefault_ShortVersion_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetDefault_AllParameters()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetDefault_AllParameters_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property")[0].GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_GetDefault_AllParameters_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_GetDefault_AllParameters_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            Response<CollectionsModelProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutAll_ShortVersion()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutAll(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutAll_ShortVersion_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutAllAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutAll_ShortVersion_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty();
            Response response = client.PutAll(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutAll_ShortVersion_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty();
            Response response = await client.PutAllAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutAll_AllParameters()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object[]
            {
new
{
property = "<property>",
}
            },
            });
            Response response = client.PutAll(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutAll_AllParameters_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object[]
            {
new
{
property = "<property>",
}
            },
            });
            Response response = await client.PutAllAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutAll_AllParameters_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty
            {
                Property = {new StringProperty
{
Property = "<property>",
}},
            };
            Response response = client.PutAll(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutAll_AllParameters_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty
            {
                Property = {new StringProperty
{
Property = "<property>",
}},
            };
            Response response = await client.PutAllAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutDefault_ShortVersion()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutDefault(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutDefault_ShortVersion_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutDefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutDefault_ShortVersion_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty();
            Response response = client.PutDefault(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutDefault_ShortVersion_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty();
            Response response = await client.PutDefaultAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutDefault_AllParameters()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object[]
            {
new
{
property = "<property>",
}
            },
            });
            Response response = client.PutDefault(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutDefault_AllParameters_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object[]
            {
new
{
property = "<property>",
}
            },
            });
            Response response = await client.PutDefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CollectionsModel_PutDefault_AllParameters_Convenience()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty
            {
                Property = {new StringProperty
{
Property = "<property>",
}},
            };
            Response response = client.PutDefault(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CollectionsModel_PutDefault_AllParameters_Convenience_Async()
        {
            CollectionsModel client = new OptionalClient().GetCollectionsModelClient(apiVersion: "1.0.0");

            CollectionsModelProperty body = new CollectionsModelProperty
            {
                Property = {new StringProperty
{
Property = "<property>",
}},
            };
            Response response = await client.PutDefaultAsync(body);
        }
    }
}
