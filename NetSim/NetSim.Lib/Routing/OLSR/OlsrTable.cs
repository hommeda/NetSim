﻿using System;
using System.Linq;

using NetSim.Lib.Simulator;

namespace NetSim.Lib.Routing.OLSR
{
    public class OlsrTable : NetSimTable
    {
        public override NetSimTableEntry GetRouteFor(string destinationId)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }
}