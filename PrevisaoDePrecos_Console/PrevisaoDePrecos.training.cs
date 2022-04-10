﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace PrevisaoDePrecos_Console
{
    public partial class PrevisaoDePrecos
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"bedrooms", @"bedrooms"),new InputOutputColumnPair(@"bathrooms", @"bathrooms"),new InputOutputColumnPair(@"sqft_lot", @"sqft_lot"),new InputOutputColumnPair(@"floors", @"floors")})      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"bedrooms",@"bathrooms",@"sqft_lot",@"floors"}))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.Regression.Trainers.Sdca(l1Regularization:15.4405367364208F,l2Regularization:5.37263302673172F,labelColumnName:@"price",featureColumnName:@"Features"));

            return pipeline;
        }
    }
}
