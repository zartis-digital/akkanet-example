namespace AkkaNet.Example
{
    internal class HouseState
    {
        public bool IsClosed { get; set; }

        public void CloseTheHouse()
        {
            IsClosed = true;
        }
    }
}
