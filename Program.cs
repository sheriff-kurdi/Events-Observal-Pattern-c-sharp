using Kurdi.Radioo;

namespace Kurdi.Radio
{
    public class Program
    {
        public static void Main()
        {
            Internal i = new();
            IRadioChannel radioChannel = new RadioChannel();
            var subscriberA = new SubscriberA();
            radioChannel.Subscribe(subscriberA);

            var SubscriberB = new SubscriberB();
            radioChannel.Subscribe(SubscriberB);

            radioChannel.RadioChannelBusiness();
            radioChannel.RadioChannelBusiness();

            radioChannel.UnSubscribe(SubscriberB);

            radioChannel.RadioChannelBusiness();

        }
    }





}