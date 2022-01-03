namespace Kurdi.Radio
{

    public class SubscriberA : ISubscriber
    {
        public void OnProdcastHandeler(string value)
        {
            System.Console.WriteLine($"Channel is:{value}");
        }

    }

}