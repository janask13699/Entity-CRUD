using System;

namespace TwilightUsers
{
    internal class Bundle
    {
        private string v;

        public Bundle(string v)
        {
            this.v = v;
        }

        internal object Include(string v)
        {
            throw new NotImplementedException();
        }
    }
}