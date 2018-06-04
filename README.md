# Samples.WebJobs.Core
Sample project to accompany https://matt-roberts.me/azure-webjobs-in-net-core-2-with-di-and-configuration/

# Notes:

I threw this together using the latest dotnet core 2.1, although you can change the project back to target dotnet core 2.0 and all should work. All you need to do is edit the appsettings.json and set something sensible for the azure connection strings. Locally, mine just point to a test azure storage account:

`DefaultEndpointsProtocol=https;AccountName=timetasticdevmatt;AccountKey=hidden==`

# Output from local run:

```04/06/2018 15:00:21 - Foo
04/06/2018 15:00:21 - Foo
04/06/2018 15:00:22 - Foo
04/06/2018 15:00:23 - Foo
04/06/2018 15:00:24 - Foo
04/06/2018 15:00:25 - Foo
04/06/2018 15:00:26 - Foo
04/06/2018 15:00:27 - Foo
04/06/2018 15:00:28 - Foo
04/06/2018 15:00:29 - Foo

