var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DBOperationsWithEFCoreApp>("dboperationswithefcoreapp");

builder.Build().Run();
