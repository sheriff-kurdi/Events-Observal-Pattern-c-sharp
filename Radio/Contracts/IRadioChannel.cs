namespace Kurdi.Radio
{
    public interface IRadioChannel
    {
        void RadioChannelBusiness();
        void Subscribe(ISubscriber observer);
        void UnSubscribe(ISubscriber observer);
    }






}