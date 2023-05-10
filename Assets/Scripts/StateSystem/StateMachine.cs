public class StateMachine
{
    private State currentState;

    public void Initialize(State startingState)
    {
        currentState = startingState;
        currentState.Initialize();
    }
    
    public void ChangeState(State newState)
    {
        currentState.Close();

        currentState = newState;
        newState.Initialize();
    }
}