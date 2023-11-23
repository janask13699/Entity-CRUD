using System;

namespace TwilightUsers
{
    internal class ScriptBundle
    {
        private string v;

        public ScriptBundle(string v)
        {
            this.v = v;
        }

        internal object Include(string v)
        {
            throw new NotImplementedException();
        }
    }
}