﻿//
//  Copyright 2013, Sami M. Kallio
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
namespace SimplyMobile.Core
{
    /// <summary>
    /// Mobile application class
    /// </summary>
    public partial class MobileApp
    {
        /// <summary>
        /// Dependency resolver
        /// </summary>
        private static DependencyResolver resolver;

        /// <summary>
        /// Gets the dependency resolver
        /// </summary>
        public static DependencyResolver Resolver
        {
            get { return resolver ?? (resolver = new DependencyResolver()); }
        }
    }
}