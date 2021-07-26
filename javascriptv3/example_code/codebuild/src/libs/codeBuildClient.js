/* Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
SPDX-License-Identifier: Apache-2.0
ABOUT THIS NODE.JS EXAMPLE: This example works with AWS SDK for JavaScript version 3 (v3),
which is available at https://github.com/aws/aws-sdk-js-v3.

Purpose:
codeBuildClient.js is a helper function that creates the Amazon CodeBuild service clients.

Inputs (replace in code):
- REGION

*/
// snippet-end:[code-build.JavaScript.codeBuildClient]
import { CodeBuildClient } from "@aws-sdk/client-codebuild";

const REGION = "eu-west-1";

// Create an AWS CodeBuild service client object.
const codeBuildClient = new CodeBuildClient({region: REGION});

export { codeBuildClient };
// snippet-end:[code-build.JavaScript.codeBuildClient]
