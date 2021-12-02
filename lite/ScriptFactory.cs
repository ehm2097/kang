using System;
using System.Collections.Generic;
using System.IO;

namespace Kang.Lite
{
    class ScriptFactory
    {
        public ScriptFactory()
        {
            var thisType = typeof(ScriptFactory);
            var stream = thisType.Assembly.GetManifestResourceStream(thisType, "command-scripts.txt");
            using (var reader = new StreamReader(stream))
            {

            }
        }

        public string GetScript(string id) => _scripts[id];

        private Dictionary<string, string> _scripts = new Dictionary<string, string>();
    }
}