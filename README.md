# aws-lambda-terraform-java

I cloned this repo from [danielbryantuk](https://github.com/danielbryantuk/aws-lambda-terraform-java-play) who created a super nice starter app showing how you can use `terraform` to create a simple lambda fronted by API Gateway. Thank you Daniel!.

This repo is a little more up to date from the original and hopefully will contain a few more code examples.

This is a _very_ simple demonstration of the code required to deploy a Java
[AWS Lambda Function](https://aws.amazon.com/lambda/) and expose the function
with [AWS API Gateway](https://aws.amazon.com/api-gateway/). The infrastructure
configuration and deployment is executed using [HashiCorp's Terraform](https://www.terraform.io/) programmable infrastructure tool.

## Get started

To get started simply create a `terraform.tfvars` file in `terraform`
directory with your AWS account/IAM User details. Your IAM User must have
[permissions](http://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_create.html)
for AWS Lambda and AWS API Gateway.

The contents should follow the template below (with you replacing the info
between `<< >>`):

```
aws_access_key = "<< your IAM user AWS access key >>"
aws_secret_key = "<< your IAM user AWS secret key >>"
region = "<< your chosen region >>"
account_id = "<<your AWS account id>>"

```

Or instead of the above, you can apply the account key and secret to your terminal session. See .`/terraform/main.tf` for more details:

```
export AWS_ACCESS_KEY_ID="<< your IAM user AWS access key >>"
export AWS_SECRET_ACCESS_KEY="<< your IAM user AWS secret key >>"
export AWS_SESSION_TOKEN="<< your session token when needed >>"
```

From the root of the project run the `build_and_deploy.sh` script.
This compiles the Java application into the `helloworld/target` directory
and runs Terraform to upload and configure the Lambda function and API Gateway.

```
$ ./build_and_deploy.sh
```

## Manually test your function

After a successful run, something similar to the output below should be visible:

```
Outputs:

curl = curl -H 'Content-Type: application/json' -X POST -d '{"name": "Emilio"}' https://XXXXXXXXXX.execute-api.eu-west-1.amazonaws.com/beta/helloworld
```

To test your Lambda deployed behind the API Gateway all you need to do is
copy/paste the curl command (minus the `curl = ` part) e.g.

```
curl -H 'Content-Type: application/json' -X POST -d '{"name": "Emilio"}' https://XXXXXXXXXX.execute-api.eu-west-1.amazonaws.com/beta/helloworld
```

## Rinse and repeat

You can make changes to the Java application and run the `build_and_deploy.sh`
script repeatedly to update the Lambda Function deployed into AWS.

## Tidy up when finished!

When you are finished, don't forget to shut your infrastructure down:

```
$ ./destroy.sh
```

## Disclaimer

Please note: I'm not responsible for any costs incurred within your AWS account :-)
