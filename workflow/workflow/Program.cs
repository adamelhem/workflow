using workflow;
using workflow.Contracts;

// Define what operations to be used
var operations = new IStrategy[] 
{ 
    new Operation1(),
    new Operation2(),
    new Operation3(),
    new Operation4()
};
var configsFile = "jsonInput.json";
var flow = new  Workflow(new Helper(), operations, configsFile);
flow.Start();