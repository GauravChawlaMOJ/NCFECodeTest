﻿using Ncfe.CodeTest;
using System;

namespace NCFECodeTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LearnerService learnerService = new LearnerService();
            learnerService.GetLearner(1, false);
        }
    }
}
