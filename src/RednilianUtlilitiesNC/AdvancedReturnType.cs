using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RednilianUtlilitiesNC
{
    /// <summary>
    /// <para>Class for returning a method result with multiple properties.</para>
    /// <para>Default Values: </para>
    /// <code>
    /// <para>ErrorMessage = string.Empty;</para>
    /// <para>IntValue = -1;</para>
    /// <para>BoolResult = false;</para>
    /// <para>GuidListResult = new();</para>
    /// <para>ObjectResult = new();</para>
    /// <para>ObjectListResult = new();</para>
    /// <para>StringList = new;</para>
    /// <para>StringResult = string.Empty;</para>
    /// </code>
    /// </summary>
    public class AdvancedReturnType
    {
        public AdvancedReturnType()
        {
            ErrorMessage = string.Empty;
            IntResult = -1;
            BoolResult = false;
            GuidListResult = new();
            ObjectResult = new();
            ObjectListResult = new();
            StringList = new();
            StringResult = string.Empty;
        }

        public string ErrorMessage { get; set; }
        public List<Guid> GuidListResult { get; set; }
        public int IntResult { get; set; }
        public bool BoolResult { get; set; }
        public Object ObjectResult { get; set; }
        public List<Object> ObjectListResult { get; set; }
        public List<String> StringList { get; set; }
        public String StringResult { get; set; }

    }
}
