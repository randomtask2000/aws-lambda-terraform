variable "aws_access_key" {}

variable "aws_secret_key" {}

variable "region" {}

variable "account_id" {}

variable "lambda_payload_filename" {
  default = "../helloworlddotnet/src/HelloWorld/bin/helloworlddotnet-0.1.0-SNAPSHOT.zip"
}

variable "lambda_function_handler" {
  default = "HelloWorld::HelloWorld.Function"
}

variable "lambda_runtime" {
  default = "netcoreapp3.1"
}

variable "api_path" {
  default = "HelloWorld"
}

variable "hello_world_http_method" {
  default = "POST"
}

variable "api_env_stage_name" {
  default = "beta"
}
