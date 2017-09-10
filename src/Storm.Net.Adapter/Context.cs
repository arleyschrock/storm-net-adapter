using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Storm
{
    public abstract class Context
    {
        public static PluginType pluginType;
        internal ComponentStreamSchema _schemaByCSharp;
        public static Logger Logger = new Logger();

        public static TopologyContext TopologyContext
        {
            set;
            get;
        }

        public static Config Config
        {
            get;
            set;
        }

        public abstract void Emit(List<object> values, string taskId = null);
        public abstract void Emit(List<StormTuple> anchors, List<object> values, string taskId = null);
        public abstract void Emit(List<object> values, long seqId, string taskId = null);
        public abstract void Emit(string streamId, List<object> values, string taskId = null);
        public abstract void Emit(string streamId, List<object> values, long seqId, string taskId = null);
        public abstract void Emit(string streamId, List<StormTuple> anchors, List<object> values, string taskId = null);
        public abstract void Ack(StormTuple tuple);
        public abstract void Fail(StormTuple tuple);

        public void DeclareComponentSchema(ComponentStreamSchema schema)
        {
            this._schemaByCSharp = schema;
        }
    }

    public class ComponentStreamSchema
    {
        public Dictionary<string, List<Type>> InputStreamSchema
        {
            get;
            set;
        }
        public Dictionary<string, List<Type>> OutputStreamSchema
        {
            get;
            set;
        }
        public ComponentStreamSchema(Dictionary<string, List<Type>> input, Dictionary<string, List<Type>> output)
        {
            this.InputStreamSchema = input;
            this.OutputStreamSchema = output;
        }
    }
}