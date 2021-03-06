/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information required for human workers to complete a labeling task.
    /// </summary>
    public partial class HumanTaskConfig
    {
        private AnnotationConsolidationConfig _annotationConsolidationConfig;
        private int? _maxConcurrentTaskCount;
        private int? _numberOfHumanWorkersPerDataObject;
        private string _preHumanTaskLambdaArn;
        private PublicWorkforceTaskPrice _publicWorkforceTaskPrice;
        private int? _taskAvailabilityLifetimeInSeconds;
        private string _taskDescription;
        private List<string> _taskKeywords = new List<string>();
        private int? _taskTimeLimitInSeconds;
        private string _taskTitle;
        private UiConfig _uiConfig;
        private string _workteamArn;

        /// <summary>
        /// Gets and sets the property AnnotationConsolidationConfig. 
        /// <para>
        /// Configures how labels are consolidated across human workers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnnotationConsolidationConfig AnnotationConsolidationConfig
        {
            get { return this._annotationConsolidationConfig; }
            set { this._annotationConsolidationConfig = value; }
        }

        // Check to see if AnnotationConsolidationConfig property is set
        internal bool IsSetAnnotationConsolidationConfig()
        {
            return this._annotationConsolidationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentTaskCount. 
        /// <para>
        /// Defines the maximum number of data objects that can be labeled by human workers at
        /// the same time. Also referred to as batch size. Each object may have more than one
        /// worker at one time. The default value is 1000 objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxConcurrentTaskCount
        {
            get { return this._maxConcurrentTaskCount.GetValueOrDefault(); }
            set { this._maxConcurrentTaskCount = value; }
        }

        // Check to see if MaxConcurrentTaskCount property is set
        internal bool IsSetMaxConcurrentTaskCount()
        {
            return this._maxConcurrentTaskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfHumanWorkersPerDataObject. 
        /// <para>
        /// The number of human workers that will label an object. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=9)]
        public int NumberOfHumanWorkersPerDataObject
        {
            get { return this._numberOfHumanWorkersPerDataObject.GetValueOrDefault(); }
            set { this._numberOfHumanWorkersPerDataObject = value; }
        }

        // Check to see if NumberOfHumanWorkersPerDataObject property is set
        internal bool IsSetNumberOfHumanWorkersPerDataObject()
        {
            return this._numberOfHumanWorkersPerDataObject.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreHumanTaskLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Lambda function that is run before a data object
        /// is sent to a human worker. Use this function to provide input to a custom labeling
        /// job.
        /// </para>
        ///  
        /// <para>
        /// For the built-in bounding box, image classification, semantic segmentation, and text
        /// classification task types, Amazon SageMaker Ground Truth provides the following Lambda
        /// functions:
        /// </para>
        ///  
        /// <para>
        ///  <b>Bounding box</b> - Finds the most similar boxes from different workers based on
        /// the Jaccard index of the boxes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-BoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-BoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-BoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-BoundingBox</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Image classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of an image based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-ImageMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-ImageMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-ImageMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-ImageMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-ImageMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label image classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of an image based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation</b> - Treats each pixel in an image as a multi-class classification
        /// and treats pixel annotations from workers as "votes" for the correct label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Text classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of text based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-TextMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-TextMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-TextMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-TextMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-TextMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-TextMultiClass</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label text classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of text based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Named entity recognition</b> - Groups similar selections and calculates aggregate
        /// boundaries, resolving to most-assigned label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Bounding box verification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true class of verification judgement for bounding box labels
        /// based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Bounding box adjustment</b> - Finds the most similar boxes from different workers
        /// based on the Jaccard index of the adjusted annotations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation verification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true class of verification judgment for semantic segmentation
        /// labels based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation adjustment</b> - Treats each pixel in an image as a multi-class
        /// classification and treats pixel adjusted annotations from workers as "votes" for the
        /// correct label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string PreHumanTaskLambdaArn
        {
            get { return this._preHumanTaskLambdaArn; }
            set { this._preHumanTaskLambdaArn = value; }
        }

        // Check to see if PreHumanTaskLambdaArn property is set
        internal bool IsSetPreHumanTaskLambdaArn()
        {
            return this._preHumanTaskLambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property PublicWorkforceTaskPrice. 
        /// <para>
        /// The price that you pay for each task performed by an Amazon Mechanical Turk worker.
        /// </para>
        /// </summary>
        public PublicWorkforceTaskPrice PublicWorkforceTaskPrice
        {
            get { return this._publicWorkforceTaskPrice; }
            set { this._publicWorkforceTaskPrice = value; }
        }

        // Check to see if PublicWorkforceTaskPrice property is set
        internal bool IsSetPublicWorkforceTaskPrice()
        {
            return this._publicWorkforceTaskPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TaskAvailabilityLifetimeInSeconds. 
        /// <para>
        /// The length of time that a task remains available for labeling by human workers. <b>If
        /// you choose the Amazon Mechanical Turk workforce, the maximum is 12 hours (43200)</b>.
        /// The default value is 864000 seconds (10 days). For private and vendor workforces,
        /// the maximum is as listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=864000)]
        public int TaskAvailabilityLifetimeInSeconds
        {
            get { return this._taskAvailabilityLifetimeInSeconds.GetValueOrDefault(); }
            set { this._taskAvailabilityLifetimeInSeconds = value; }
        }

        // Check to see if TaskAvailabilityLifetimeInSeconds property is set
        internal bool IsSetTaskAvailabilityLifetimeInSeconds()
        {
            return this._taskAvailabilityLifetimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskDescription. 
        /// <para>
        /// A description of the task for your human workers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TaskDescription
        {
            get { return this._taskDescription; }
            set { this._taskDescription = value; }
        }

        // Check to see if TaskDescription property is set
        internal bool IsSetTaskDescription()
        {
            return this._taskDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TaskKeywords. 
        /// <para>
        /// Keywords used to describe the task so that workers on Amazon Mechanical Turk can discover
        /// the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> TaskKeywords
        {
            get { return this._taskKeywords; }
            set { this._taskKeywords = value; }
        }

        // Check to see if TaskKeywords property is set
        internal bool IsSetTaskKeywords()
        {
            return this._taskKeywords != null && this._taskKeywords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskTimeLimitInSeconds. 
        /// <para>
        /// The amount of time that a worker has to complete a task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=30, Max=604800)]
        public int TaskTimeLimitInSeconds
        {
            get { return this._taskTimeLimitInSeconds.GetValueOrDefault(); }
            set { this._taskTimeLimitInSeconds = value; }
        }

        // Check to see if TaskTimeLimitInSeconds property is set
        internal bool IsSetTaskTimeLimitInSeconds()
        {
            return this._taskTimeLimitInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskTitle. 
        /// <para>
        /// A title for the task for your human workers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskTitle
        {
            get { return this._taskTitle; }
            set { this._taskTitle = value; }
        }

        // Check to see if TaskTitle property is set
        internal bool IsSetTaskTitle()
        {
            return this._taskTitle != null;
        }

        /// <summary>
        /// Gets and sets the property UiConfig. 
        /// <para>
        /// Information about the user interface that workers use to complete the labeling task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UiConfig UiConfig
        {
            get { return this._uiConfig; }
            set { this._uiConfig = value; }
        }

        // Check to see if UiConfig property is set
        internal bool IsSetUiConfig()
        {
            return this._uiConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the work team assigned to complete the tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string WorkteamArn
        {
            get { return this._workteamArn; }
            set { this._workteamArn = value; }
        }

        // Check to see if WorkteamArn property is set
        internal bool IsSetWorkteamArn()
        {
            return this._workteamArn != null;
        }

    }
}