// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

import { InputClient } from "./InputClient.js";
import { InputModelType } from "./InputType.js";

export interface CodeModel {
    Name: string;
    Description?: string;
    ApiVersions: string[];
    Models: InputModelType[];
    Clients: InputClient[];
    Auth: any;
}
