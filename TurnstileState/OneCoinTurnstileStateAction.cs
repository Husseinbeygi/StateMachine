namespace TurnstileState;

public class OneCoinTurnstileStateLOCKED : ITurnstileState
{

	public void Coin(TurnstileFSM turnstileFSM)
	{
		turnstileFSM.State = new OneCoinTurnstileStateUNLOCKED();
		turnstileFSM.Unlock();
	}

	public void Pass(TurnstileFSM turnstileFSM)
	{
		turnstileFSM.Alarm();
	}
}


public class OneCoinTurnstileStateUNLOCKED : ITurnstileState
{

	public void Coin(TurnstileFSM turnstileFSM)
	{
		turnstileFSM.ThankYou();
	}

	public void Pass(TurnstileFSM turnstileFSM)
	{
		turnstileFSM.State = new OneCoinTurnstileStateLOCKED();
		turnstileFSM.Lock();
	}
}

