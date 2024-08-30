namespace BrunoSpaBlazor.Services
{
    public enum ToastLevel
    {
        Info,
        Success,
        Warning,
        Error
    }

    public class ToastService
    {
        public event Action<string, ToastLevel>? OnShow;
        public event Action? OnHide;

        public void ShowToast(string message, ToastLevel level)
        {
            OnShow?.Invoke(message, level);
            StartCountdown();
        }

        private void StartCountdown()
        {
            var timer = new System.Timers.Timer(5000);
            timer.Elapsed += (sender, args) => OnHide?.Invoke();
            timer.AutoReset = false;
            timer.Start();
        }
    }

}
