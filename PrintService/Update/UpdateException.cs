﻿using System;

namespace PrintService.Update
{
    public class UpdateException : Exception
    {
        private StepEnum step = 0;

        public StepEnum GetStep()
        {
            return this.step;
        }

        public UpdateException(StepEnum onStep, string message) : base(message)
        {
            this.step = onStep;
        }
    }
}
