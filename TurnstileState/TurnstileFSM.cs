namespace TurnstileState;

public abstract class TurnstileFSM
{
	public ITurnstileState State { get;  set; }

	public void Pass()
	{
		State.Pass(this);
	}

	public void Coin()
	{
		State.Coin(this);
	}

	public abstract void Alarm();
	public abstract void Lock();
	public abstract void Unlock();
	public abstract void ThankYou();
}