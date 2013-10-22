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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStorediSCSIVolume operation.
    /// 
    /// </summary>
    public partial class CreateStorediSCSIVolumeRequest : AmazonWebServiceRequest
    {
        private string gatewayARN;
        private string diskId;
        private string snapshotId;
        private bool? preserveExistingData;
        private string targetName;
        private string networkInterfaceId;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }

        /// <summary>
        /// The unique identifier for the gateway local disk that is configured as a stored volume. Use <a
        /// href="http://docs.aws.amazon.com/storagegateway/latest/userguide/API_ListLocalDisks.html">ListLocalDisks</a> to list disk IDs for a gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 300</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DiskId
        {
            get { return this.diskId; }
            set { this.diskId = value; }
        }

        // Check to see if DiskId property is set
        internal bool IsSetDiskId()
        {
            return this.diskId != null;
        }

        /// <summary>
        /// The snapshot ID (e.g. "snap-1122aabb") of the snapshot to restore as the new stored volume. Specify this field if you want to create the
        /// iSCSI storage volume from a snapshot otherwise do not include this field. To list snapshots for your account use <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a> in the
        /// <i>Amazon Elastic Compute Cloud API Reference</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\Asnap-[0-9a-fA-F]{8}\z</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// Specify this field as true if you want to preserve the data on the local disk. Otherwise, specifying this field as false creates an empty
        /// volume. <i>Valid Values</i>: true, false
        ///  
        /// </summary>
        public bool PreserveExistingData
        {
            get { return this.preserveExistingData ?? default(bool); }
            set { this.preserveExistingData = value; }
        }

        // Check to see if PreserveExistingData property is set
        internal bool IsSetPreserveExistingData()
        {
            return this.preserveExistingData.HasValue;
        }

        /// <summary>
        /// The name of the iSCSI target used by initiators to connect to the target and as a suffix for the target ARN. For example, specifying
        /// <c>TargetName</c> as <i>myvolume</i> results in the target ARN of
        /// arn:aws:storagegateway:us-east-1:111122223333:gateway/mygateway/target/iqn.1997-05.com.amazon:myvolume. The target name must be unique
        /// across all volumes of a gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 200</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^[-\.;a-z0-9]+$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TargetName
        {
            get { return this.targetName; }
            set { this.targetName = value; }
        }

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this.targetName != null;
        }

        /// <summary>
        /// The network interface of the gateway on which to expose the iSCSI target. Only IPv4 addresses are accepted. Use
        /// <a>DescribeGatewayInformation</a> to get a list of the network interfaces available on a gateway. <i>Valid Values</i>: A valid IP address.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\A(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\z</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

    }
}
    
