namespace WebSocketStreamingWithUI.Data
{
    public interface IUser
    {
        float GetBalance();
        string GetUser();
        void GetUserDetails();
        void InsertToHistory();
        void UpdateUserBalance(string amount);
    }
}