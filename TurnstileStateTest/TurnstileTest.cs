using TurnstileState;

namespace TurnstileStateTest;

public class TurnstileTest : TurnstileFSM
{
	string actions = string.Empty;
	TurnstileFSM fsm;
	public TurnstileTest()
	{
		fsm = this;
		fsm.State = new OneCoinTurnstileStateLOCKED();
	}

	private void AssertActions(string expected) { Assert.True(expected == actions); }

	[Fact]
	public void NormalOperation()
	{
		Coin();
		AssertActions("U");
		Pass();
		AssertActions("UL");
	}

	[Fact]
	public void ForceEntry()
	{
		Pass();
		AssertActions("A");
	}

	[Fact]
	public void DoubleCoin()
	{
		Coin();
		Coin();
		AssertActions("UT");
	}

	[Fact]
	public void ManyCoinThenPass()
	{
		Coin();
		Coin();
		Coin();
		Coin();
		Coin();
		Coin();
		Pass();
		AssertActions("UTTTTTL");
	}

	public override void Alarm()
	{
		actions += 'A';
	}

	public override void Lock()
	{
		actions += 'L';
	}

	public override void ThankYou()
	{
		actions += 'T';
	}

	public override void Unlock()
	{
		actions += 'U';
	}
}