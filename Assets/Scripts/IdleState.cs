using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class IdleState : StateBase
{
    private float horizontalInput, verticalInput;

    public IdleState(Character character, StateMachine stateMachine) : base(character, stateMachine)
    {

    }

    public override void Enter()
    {
        base.Enter();

        horizontalInput = verticalInput = 0;
        Debug.Log("Idle State");
    }

    public override void HandleInput()
    {
        base.HandleInput();

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (horizontalInput != 0 || verticalInput != 0)
        {
            StateMachine.ChangeState(Character.RunState);
            Debug.Log("State change");
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void Exit()
    {
        base.Exit();
        Character.ResetParams();
    }
}

