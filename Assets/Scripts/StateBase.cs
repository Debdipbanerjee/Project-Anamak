using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase
{
    protected Character Character;
    protected StateMachine StateMachine;

    protected StateBase(Character character, StateMachine stateMachine)
    {
        this.Character = character;
        this.StateMachine = stateMachine;
    }

    public virtual void Enter()
    {

    }

    //Update Loop
    public virtual void HandleInput()
    {

    }

    public virtual void LogicUpdate()
    {

    }

    public virtual void PhysicsUpdate()
    {

    }

    //

    public virtual void Exit()
    {

    }
}
