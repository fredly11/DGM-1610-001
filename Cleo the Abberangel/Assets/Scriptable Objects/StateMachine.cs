
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class StateMachine : ScriptableObject
{

	public UnityEvent state1Event, State2Event, state3Event, state4Event;
	public enum states
	{
		state1,
		state2,
		state3,
		state4
	}

	public states currentState;
	// Use this for initialization
	private void OnEnable()
	{

	}

	
	// Update is called once per frame
	public void OnSwitch () {

		switch (currentState)
		{
			case states.state1:
				state1Event.Invoke();
				break;
			case states.state2:
				State2Event.Invoke();
				break;
			case states.state3:
				state3Event.Invoke();
				break;
			case states.state4:
				state3Event.Invoke();
				break;
			default:
				//stuff
				break;
		}
	}
}
