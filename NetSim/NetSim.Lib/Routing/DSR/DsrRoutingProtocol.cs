﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetSim.Lib.Simulator;

namespace NetSim.Lib.Routing.DSR
{
    public class DsrRoutingProtocol : NetSimRoutingProtocol
    {
        public DsrRoutingProtocol(NetSimClient client)
            : base(client)
        {
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void PerformRoutingStep()
        {
            throw new NotImplementedException();
        }
    }
}
