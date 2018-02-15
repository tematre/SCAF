
namespace BeautySalon.BotEngine.Core
{
    public interface ISmartControllerManager
    {
        void AddBot(ISmartController bot);

        void RemoveBot(ISmartController bot);
    }
}
