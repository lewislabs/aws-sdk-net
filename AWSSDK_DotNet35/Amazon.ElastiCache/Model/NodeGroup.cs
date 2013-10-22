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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents a collection of cache nodes in a replication group.</para>
    /// </summary>
    public class NodeGroup
    {
        
        private string nodeGroupId;
        private string status;
        private Endpoint primaryEndpoint;
        private List<NodeGroupMember> nodeGroupMembers = new List<NodeGroupMember>();

        /// <summary>
        /// The identifier for the node group. A replication group contains only one node group; therefore, the node group ID is 0001.
        ///  
        /// </summary>
        public string NodeGroupId
        {
            get { return this.nodeGroupId; }
            set { this.nodeGroupId = value; }
        }

        // Check to see if NodeGroupId property is set
        internal bool IsSetNodeGroupId()
        {
            return this.nodeGroupId != null;
        }

        /// <summary>
        /// The current state of this replication group - <i>creating</i>, <i>available</i>, etc.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Represents the information required for client programs to connect to a cache node.
        ///  
        /// </summary>
        public Endpoint PrimaryEndpoint
        {
            get { return this.primaryEndpoint; }
            set { this.primaryEndpoint = value; }
        }

        // Check to see if PrimaryEndpoint property is set
        internal bool IsSetPrimaryEndpoint()
        {
            return this.primaryEndpoint != null;
        }

        /// <summary>
        /// A list containing information about individual nodes within the node group.
        ///  
        /// </summary>
        public List<NodeGroupMember> NodeGroupMembers
        {
            get { return this.nodeGroupMembers; }
            set { this.nodeGroupMembers = value; }
        }

        // Check to see if NodeGroupMembers property is set
        internal bool IsSetNodeGroupMembers()
        {
            return this.nodeGroupMembers.Count > 0;
        }
    }
}
