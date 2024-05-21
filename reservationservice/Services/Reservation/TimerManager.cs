namespace reservationservice.Services.Reservation;

public class TimerManager
{
    public int InitialIntervalMinutes { get; } = 1;
    private const int ResetIntervalSeconds = 5;
    private readonly Func<Guid, System.Timers.Timer, Task> _onTimerElapsed;

    public TimerManager(Func<Guid, System.Timers.Timer, Task> onTimerElapsed)
    {
        _onTimerElapsed = onTimerElapsed;
    }

    public void StartInitialTimer(Guid reservationId)
    {
        StartTimer(reservationId, InitialIntervalMinutes * 60 * 1000);
    }

    public void ResetTimer(Guid reservationId)
    {
        StartTimer(reservationId, ResetIntervalSeconds * 1000);
    }

    private void StartTimer(Guid reservationId, double interval)
    {
        var timer = new System.Timers.Timer(interval);
        timer.Elapsed += async (sender, e) =>
        {
            timer.Stop();
            await _onTimerElapsed(reservationId, timer);
        };
        timer.AutoReset = false;
        timer.Start();
    }
}