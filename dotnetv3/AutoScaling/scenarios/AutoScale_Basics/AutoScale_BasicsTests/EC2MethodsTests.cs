﻿// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier:  Apache-2.0

using AutoScale_Basics;
using Amazon.EC2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoScale_Basics.Tests
{
    [TestClass()]
    public class EC2MethodsTests
    {
        private static readonly string imageId = "ami-05803413c51f242b7";
        private static readonly string instanceType = "t2.micro";
        private static readonly string launchTemplateName = "AutoScaleLaunchTemplateTest";
        private static string launchTemplateId = string.Empty;

        [TestMethod()]
        public async Task CreateLaunchTemplateAsyncTest()
        {
            launchTemplateId = await EC2Methods.CreateLaunchTemplateAsync(imageId, instanceType, launchTemplateName);
            Assert.IsTrue(launchTemplateId != String.Empty, "Couldn't create launch template.");
        }

        [TestMethod()]
        public async Task DeleteLaunchTemplateAsyncTest()
        {
            var deletedLaunchTemplateName = await EC2Methods.DeleteLaunchTemplateAsync(launchTemplateId);
            Assert.IsTrue(deletedLaunchTemplateName == launchTemplateName, "Could not delete the launch template.");
        }

        [TestMethod()]
        public async Task DescribeLaunchTemplateAsyncTest()
        {
            var success = await EC2Methods.DescribeLaunchTemplateAsync(launchTemplateName);
            Assert.IsTrue(success, "Couldn't find any launch templates with the name {templateName}");
        }
    }
}