namespace TurnstileState;

public interface ITurnstileState
{
	void Coin(TurnstileFSM turnstileFSM);
	void Pass(TurnstileFSM turnstileFSM);
}