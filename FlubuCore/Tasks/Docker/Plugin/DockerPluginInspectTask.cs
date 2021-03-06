
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Plugin
{
     public partial class DockerPluginInspectTask : ExternalProcessTaskBase<DockerPluginInspectTask>
     {
        private string[] _plugin;

        
        public DockerPluginInspectTask(params string[] plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin inspect");
_plugin = plugin;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerPluginInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_plugin);

            return base.DoExecute(context);
        }

     }
}
