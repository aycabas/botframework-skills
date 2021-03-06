﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace ToDoSkill.Models.Action
{
    public class ToDoInfo
    {
        [JsonProperty("listType")]
        public string ListType { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }
    }
}
