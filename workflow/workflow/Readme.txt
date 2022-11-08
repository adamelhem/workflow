The workflow is constructed from different steps and is defined in a
json document.
Operations
There are currently 4 operations. Each operation gets a number as
input and return number as output which is carried to the next
operation as input.
 operation 1: Adds 3 to the input number.
 operation 2: Multiply the input number by 5.
 operation 3: Divide the input number by 2.
 operation 4: If the input number contains the digit 7 or
divides by 7 (with a remainder of zero) – throws an exception
and stop the workflow, otherwise Add 7 to the input number.
Workflow definition
The workflow is a collection of steps.
Each step has:
1. unique id
2. operation name to execute
3. the next id to run if the output is < 10
4. the next id to run if the output is >= 10
5. if the output number is exactly 10 – the workflow stops
the workflow should be loaded from a json document (see example in
the next page) and start at the first step.
How to write the exercise
1. Create a .net framework console application
2. Create unit test project
3. Read the json file and create the workflow
4. Prompt the user to enter an input number (Console.ReadLine)
5. Run the workflow with given number
6. Write tests for your classes
Extra Features
7. Cancellation. Prevent the workflow from running longer than 15
seconds. how about running the workflow with cancellation
token?
8. Dependency Injection. Allow the operations to support
dependency injection. (for example, operation 2 needs consumes
another service to get the number to multiply by).
9. Reflection. Load operations dynamically from other assemblies.
(for example, create an operation called "plus 10", put the
assembly in the bin and modify the json (without updating your
code)
10. Logging. Add logging to each step to write the input and
the output (create your own ILog interface)
11. Persistence. If the program is stopped while the workflow
is running, it will resume the workflow from the same location
when the program starts again.

Example
See the workflow definition in the next page.
Assume the user starts with input number: 3
Step 1: 3->6 (6 is less than 10, goes back to step 1)
Step 1: 6->9 (9 is less than 10, goes back to step 1)
Step 1: 9->12 (12 is greater than 10, goes to step 2)
Step 2: 12->6
Step 5: 6->30
Step 1: 30->33
Etc.
{
 "steps": [
 {
 "id": 1,
 "operationName": "operation 1",
 "nextIdIfOutputIsLessThan": 1,
 "nextIdIfOutputIsGreaterThan": 2
 },
 {
 "id": 2,
 "operationName": "operation 3",
 "nextIdIfOutputIsLessThan": 5,
 "nextIdIfOutputIsGreaterThan": 3
 },
 {
 "id": 3,
 "operationName": "operation 4",
 "nextIdIfOutputIsLessThan": 1,
 "nextIdIfOutputIsGreaterThan": 3
 },
 {
 "id": 4,
 "operationName": "operation 4",
 "nextIdIfOutputIsLessThan": 5,
 "nextIdIfOutputIsGreaterThan": 4
 },
 {
 "id": 5,
 "operationName": "operation 2",
 "nextIdIfOutputIsLessThan": 5,
 "nextIdIfOutputIsGreaterThan": 1
 }
 ]
}