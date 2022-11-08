using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflow.Contracts;

namespace workflow
{
    public class Workflow : IWorkflow
    {
        private Step[] _steps;
        private StepsManager _stepsManager;

        public Workflow(IHelper helper, IStrategy[] operations, string configsFilePath)
        {
            _steps = helper.LoadJsonFile<StepsConfigurations>(configsFilePath).steps.ToArray();
            _stepsManager = new StepsManager(_steps, operations);
        }

        public void Start()
        {
            float inputNo = 0;
            var validInput = false;
            // Ask user to input a number
            do
            {
                Console.WriteLine("Please enter a number");
                var number = Console.ReadLine();
                validInput = float.TryParse(number, out inputNo);
            } while (!validInput);

            StepResult result = new StepResult { OutputNumber = inputNo, NextStep = _steps[0] };

            do
            {
                result = _stepsManager.GetNextStep(result.OutputNumber, result.NextStep);
            } while (result.NextStep.id != -1);
        }
    }
}