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
using System.Net;
using System.Collections.Generic;
using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetDistributionConfig operation
    /// </summary>
    internal class GetDistributionConfigResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetDistributionConfigResponse response = new GetDistributionConfigResponse();
            
            UnmarshallResult(context,response);
             
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,GetDistributionConfigResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DistributionConfig", targetDepth))
                    {
                        response.DistributionConfig = DistributionConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
                

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("ETag"))
                response.ETag = responseData.GetHeaderValue("ETag");            


            return;
        }
        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchDistribution"))
            {
                return new NoSuchDistributionException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDenied"))
            {
                return new AccessDeniedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonCloudFrontException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static GetDistributionConfigResponseUnmarshaller instance;

        public static GetDistributionConfigResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new GetDistributionConfigResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
