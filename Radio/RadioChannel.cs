namespace Kurdi.Radio
{

    public class RadioChannel : IRadioChannel
    {
 
        public string? Value { get; private set; }

        private event Action<string>? OnProdcast;

        public void Subscribe(ISubscriber subscriber)
        {
            Console.WriteLine("Subject: observer Subscribed.");
            this.OnProdcast += subscriber.OnProdcastHandeler;
        }


        public void UnSubscribe(ISubscriber subscriber)
        {
            Console.WriteLine("Subject: observer Unsubscribed.");
            this.OnProdcast -= subscriber.OnProdcastHandeler;
        }

        // Trigger an update in each subscriber.

        public void ProdCast()
        {
            this.OnProdcast?.Invoke(this.Value);
        }

        public void RadioChannelBusiness()
        {
            Console.WriteLine("\nSubject: I'm doing RadioChannelBusiness.");
            this.Value = new Random().Next(0, 10).ToString();

            Thread.Sleep(15);

            Console.WriteLine("Subject: RadioChannelBusiness is: " + this.Value);
            this.ProdCast();
        }
    }






}