﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetSim.Lib.Simulator;
using NetSim.Lib.Simulator.Components;

namespace NetSim.Lib.Routing.DSR
{
    public class DsrTableEntry : NetSimTableEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DsrTableEntry"/> class.
        /// </summary>
        public DsrTableEntry()
        {
            this.Route = new List<string>();
        }

        /// <summary>
        /// Gets or sets the route.
        /// </summary>
        /// <value>
        /// The route.
        /// </value>
        public List<string> Route { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            return new DsrTableEntry() { Destination = Destination, Route = new List<string>(this.Route) };
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return !IsReachable ? $"{Destination,4} {"---",6}" : $"{Destination,4} {Metric,5} {String.Join(",", Route)}";
        }
    }
}
