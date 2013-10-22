/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents the output of a DescribeCacheEngineVersions operation.</para>
    /// </summary>
    public partial class DescribeCacheEngineVersionsResult : AmazonWebServiceResponse
    {
        
        private string marker;
        private List<CacheEngineVersion> cacheEngineVersions = new List<CacheEngineVersion>();

        /// <summary>
        /// Provides an identifier to allow retrieval of paginated results.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of cache engine version details. Each element in the list contains detailed information about once cache engine version.
        ///  
        /// </summary>
        public List<CacheEngineVersion> CacheEngineVersions
        {
            get { return this.cacheEngineVersions; }
            set { this.cacheEngineVersions = value; }
        }

        // Check to see if CacheEngineVersions property is set
        internal bool IsSetCacheEngineVersions()
        {
            return this.cacheEngineVersions.Count > 0;
        }
    }
}
