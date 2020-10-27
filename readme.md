**Instructions**

1. On `Line:25` inside of `serveless.yml` replace `AWS_ACCOUNT_NUMBER` and `LAYER_VERSION` with correct values
2. Run `build`
3. Run `serverless deploy`

`Scheduled` function will be executed every 10 minutes. 

`Hello` function can be executed from AWS Console, or using AWS Command Line interface:

`aws lambda invoke --function-name csharp-dev-hello result.json`

Check the `result.json` file to see response.

Check `CloudWatch` for functions logs.

Normally you would want to have layers and functions separated into 2 stacks. For the sake of simplicity this example contains both in a single stack. 
