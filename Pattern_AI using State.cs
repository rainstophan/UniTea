// The state pattern is a design pattern that is used to represent the behavior of an object based on its internal state. It allows an object to alter its behavior when its internal state changes, without changing its class.
public abstract class State
{
    protected Context context;

    public void SetContext(Context context)
    {
        this.context = context;
    }

    public abstract void HandleInput();
    public abstract void Update();
}

public class IdleState : State
{
    public override void HandleInput()
    {
        // Handle input for the idle state
    }

    public override void Update()
    {
        // Update the idle state
    }
}

public class WalkState : State
{
    public override void HandleInput()
    {
        // Handle input for the walk state
    }

    public override void Update()
    {
        // Update the walk state
    }
}

public class Context
{
    private State currentState;

    public Context(State initialState)
    {
        currentState = initialState;
        currentState.SetContext(this);
    }

    public void SetState(State newState)
    {
        currentState = newState;
        currentState.SetContext(this);
    }

    public void HandleInput()
    {
        currentState.HandleInput();
    }

    public void Update()
    {
        currentState.Update();
    }
}

// **************************
//you can create instances of the different state classes and assign them to the context object as needed. For example, you might use the following code to transition from the idle state to the walk state:
Context context = new Context(new IdleState());
context.SetState(new WalkState());
// You can then invoke the HandleInput and Update methods on the context object to execute the behavior of the current state. For example
void Update()
{
    context.HandleInput();
    context.Update();
}
