namespace Kurdi.Radio
{
    public class SubscriberB : ISubscriber
    {
        public void OnProdcastHandeler(string value)
        {
            System.Console.WriteLine($"Channel is:{value}");
        }
    }


}