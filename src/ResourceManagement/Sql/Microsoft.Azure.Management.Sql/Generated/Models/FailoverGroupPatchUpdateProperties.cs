// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Patch Update Azure Sql Database parameters properties.
    /// </summary>
    public partial class FailoverGroupPatchUpdateProperties
    {
        private IList<string> _databases;
        
        /// <summary>
        /// Optional. Gets the list of Azure SQL Databases for the Failover
        /// Group
        /// </summary>
        public IList<string> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }
        
        private ReadOnlyEndpoint _readOnlyEndpoint;
        
        /// <summary>
        /// Optional. Gets the readonly endpoint of the Azure SQL Database
        /// Failover Group
        /// </summary>
        public ReadOnlyEndpoint ReadOnlyEndpoint
        {
            get { return this._readOnlyEndpoint; }
            set { this._readOnlyEndpoint = value; }
        }
        
        private ReadWriteEndpoint _readWriteEndpoint;
        
        /// <summary>
        /// Optional. Gets the read-write endpoint of the Azure SQL Database
        /// Failover Group
        /// </summary>
        public ReadWriteEndpoint ReadWriteEndpoint
        {
            get { return this._readWriteEndpoint; }
            set { this._readWriteEndpoint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// FailoverGroupPatchUpdateProperties class.
        /// </summary>
        public FailoverGroupPatchUpdateProperties()
        {
            this.Databases = new LazyList<string>();
        }
    }
}