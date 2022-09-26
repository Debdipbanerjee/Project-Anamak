using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateMachine
{
    public StateBase CurrentState
    {
        get;
        private set;
    }

    public void Initialize(StateBase StartingState)
    {
        CurrentState = StartingState;
        StartingState.Enter();
    }

    public void ChangeState(StateBase newState)
    {
        CurrentState.Exit();

        CurrentState = newState;
        newState.Enter();
    }
}


