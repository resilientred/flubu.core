
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Stack
{
     public partial class DockerStackDeployTask : ExternalProcessTaskBase<DockerStackDeployTask>
     {
        private string _stack;

        
        public DockerStackDeployTask(string stack)
        {
            ExecutablePath = "docker";
            WithArguments("stack deploy");
_stack = stack;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Path to a Distributed Application Bundle file
        /// </summary>
        public DockerStackDeployTask BundleFile(string bundleFile)
        {
            WithArgumentsValueRequired("bundle-file", bundleFile.ToString());
            return this;
        }

        /// <summary>
        /// Path to a Compose file
        /// </summary>
        public DockerStackDeployTask ComposeFile(string composeFile)
        {
            WithArgumentsValueRequired("compose-file", composeFile.ToString());
            return this;
        }

        /// <summary>
        /// Prune services that are no longer referenced
        /// </summary>
        public DockerStackDeployTask Prune()
        {
            WithArguments("prune");
            return this;
        }

        /// <summary>
        /// Query the registry to resolve image digest and supported platforms ("always"|"changed"|"never")

        /// </summary>
        public DockerStackDeployTask ResolveImage(string resolveImage)
        {
            WithArgumentsValueRequired("resolve-image", resolveImage.ToString());
            return this;
        }

        /// <summary>
        /// Send registry authentication details to Swarm agents
        /// </summary>
        public DockerStackDeployTask WithRegistryAuth()
        {
            WithArguments("with-registry-auth");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_stack);

            return base.DoExecute(context);
        }

     }
}
