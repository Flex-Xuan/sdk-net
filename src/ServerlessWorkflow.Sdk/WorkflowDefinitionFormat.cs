﻿/*
 * Copyright 2021-Present The Serverless Workflow Specification Authors
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System.Runtime.Serialization;

namespace ServerlessWorkflow.Sdk
{

    /// <summary>
    /// Enumerates all workflow definition formats
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.StringEnumConverterFactory))]
    public enum WorkflowDefinitionFormat
    {
        /// <summary>
        /// Indicates YAML
        /// </summary>
        [EnumMember(Value = "yaml")]
        Yaml = 1,
        /// <summary>
        /// Indicates JSON
        /// </summary>
        [EnumMember(Value = "json")]
        Json = 2
    }

}
