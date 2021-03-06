
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Network
{
     public partial class DockerNetworkDisconnectTask : ExternalProcessTaskBase<DockerNetworkDisconnectTask>
     {
        private string _network;
private string _container;

        
        public DockerNetworkDisconnectTask(string network,  string container)
        {
            ExecutablePath = "docker";
            WithArguments("network disconnect");
_network = network;
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force the container to disconnect from a network
        /// </summary>
        public DockerNetworkDisconnectTask Force()
        {
            WithArguments("force");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_network);
 WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
