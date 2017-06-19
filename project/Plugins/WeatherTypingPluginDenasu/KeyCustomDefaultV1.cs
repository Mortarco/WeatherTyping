﻿/*
 * Copyright 2017 Denasu System
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;

namespace com.denasu.WeatherTyping.plugin.input
{
    /// <summary>
    /// Default key custom
    /// </summary>
    internal class KeyCustomDefaultV1 : MarshalByRefObject, IKeyCustom
    {
        /// <summary>
        /// Add key map
        /// </summary>
        /// <param name="name">Key map name</param>
        /// <param name="keyCode">Key code</param>
        public void SetMappedKey(string name, WTKeyCode keyCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get key map
        /// </summary>
        /// <param name="name">Key map name</param>
        /// <returns>Key code</returns>
        WTKeyCode IKeyCustom.GetMappedKey(string name)
        {
            throw new NotImplementedException();
        }
    }
}
