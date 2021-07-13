provider "aws" {
  region     = var.region
  /*
  You can set and uncomment these or apply them with EXPORTs to your terminal session.

cat << EOF > terraform.tfvars
  aws_access_key = "<< your IAM user AWS access key >>"
  aws_secret_key = "<< your IAM user AWS secret key >>"
  account_id = "<<your AWS account id>>"
EOF

  export AWS_ACCESS_KEY_ID="<< your IAM user AWS access key >>"
  export AWS_SECRET_ACCESS_KEY="<< your IAM user AWS secret key >>"
  export AWS_SESSION_TOKEN="<< your session token when needed >>"

  */
}
