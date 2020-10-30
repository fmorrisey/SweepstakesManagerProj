﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    /// <summary>
    /// Dependency injection of the Sweepstakes
    /// </summary>
    public interface ISweepstakesManager
    {

        void InsertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();

    }
}