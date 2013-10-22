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
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CopyImage operation.
    /// 
    /// </summary>
    public partial class CopyImageRequest : AmazonWebServiceRequest
    {
        private bool? dryRun;
        private string sourceRegion;
        private string sourceImageId;
        private string name;
        private string description;
        private string clientToken;
        public bool DryRun
        {
            get { return this.dryRun ?? default(bool); }
            set { this.dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this.dryRun.HasValue;
        }
        public string SourceRegion
        {
            get { return this.sourceRegion; }
            set { this.sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this.sourceRegion != null;
        }
        public string SourceImageId
        {
            get { return this.sourceImageId; }
            set { this.sourceImageId = value; }
        }

        // Check to see if SourceImageId property is set
        internal bool IsSetSourceImageId()
        {
            return this.sourceImageId != null;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }

    }
}
    
