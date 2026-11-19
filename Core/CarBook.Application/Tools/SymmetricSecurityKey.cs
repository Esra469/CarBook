namespace CarBook.Application.Tools
{
    internal class SymmetricSecurityKey
    {
        private byte[] bytes;

        public SymmetricSecurityKey(byte[] bytes)
        {
            this.bytes = bytes;
        }
    }
}