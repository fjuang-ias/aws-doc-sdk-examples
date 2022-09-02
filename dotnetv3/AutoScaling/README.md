# Amazon EC2 Auto Scaling code examples for the AWS SDK for .NET (v3)

## Overview

The examples in this directory show how to use Amazon EC2 Auto Scaling with the
AWS SDK for .NET (v3).

Use Amazon EC2 Auto Scaling to automatically scale Amazon EC2 instances, either
with scaling policies or with scheduled scaling.

## ⚠️ Important

- Running this code might result in charges to your AWS account.
- We recommend that you grant your code least privilege, or at most the minimum
  permissions required to perform the task. For more information, see
  [Grant least privilege](https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#grant-least-privilege).
- This code is not tested in all AWS Regions. For more information, see
  [AWS Regional Services](https://aws.amazon.com/about-aws/global-infrastructure/regional-product-services/).

## Code examples

### Single actions

- [Create Auto Scaling group](scenarios/AutoScale_Basics) (`CreateAutoScalingGroupAsync`)
- [Describe account limits](scenarios/AutoScale_Basics) (`DescribeAccountLimitsAsync`)
- [Describe scaling activities](scenarios/AutoScale_Basics) (`DescribeScalingActivitiesAsync`)
- [Describe Auto Scaling instances](scenarios/AutoScale_Basics) (`DescribeAutoScalingInstancesAsync`)
- [Describe Auto Scaling groups](scenarios/AutoScale_Basics) (`DescribeAutoScalingGroupsAsync`)
- [Delete Auto Scaling group](scenarios/AutoScale_Basics) (`DeleteAutoScalingGroupAsync`)
- [Enable metric collection](scenarios/AutoScale_Basics) (`EnableMetricsCollectionAsync`)
- [Disable metric collection](scenarios/AutoScale_Basics) (`DeleteAutoScalingGroupAsync`)
- [Set desired capacity](scenarios/AutoScale_Basics) (`SetDesiredCapacityAsync`)
- [Terminate an instance in an Auto Scaling group](scenarios/AutoScale_Basics) (`TerminateInstanceInAutoScalingGroupAsync`)
- [Update an Auto Scaling group](scenarios/AutoScale_Basics) (`UpdateAutoScalingGroupAsync`)

### Scenario

[Auto Scaling basics](scenarios/AutoScale_Basics)

## Run the Examples

After the example compiles, you can run it from the command line. To do so,
navigate to the folder that contains the .csproj file and run the following
command:

```
dotnet run
```

Alternatively, you can run the example from within your IDE.

## Resources and documentation

- [Amazon EC2 Auto Scaling documentation](https://docs.aws.amazon.com/autoscaling/?id=docs_gateway#amazon-ec2-auto-scaling)
- [AWS SDK for .NET Developer Guide](https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/welcome.html)
- [AWS SDK for .NET API Reference](https://docs.aws.amazon.com/sdkfornet/v3/apidocs/index.html)

Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved. SPDX-License-Identifier: Apache-2.0
