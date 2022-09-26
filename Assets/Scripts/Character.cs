using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Character : MonoBehaviour
{
    public StateMachine MovementStateMachine;
    public IdleState IdleState;
    public RunState RunState;

    public CharacterController Controller;
    public float speed = 6f;
    public Vector3 Movement;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Controller = GetComponent<CharacterController>();

        MovementStateMachine = new StateMachine();

        IdleState = new IdleState(this, MovementStateMachine);
        RunState = new RunState(this, MovementStateMachine);

        MovementStateMachine.Initialize(IdleState);
    }

    // Update is called once per frame
    void Update()
    {
        MovementStateMachine.CurrentState.HandleInput();
        MovementStateMachine.CurrentState.LogicUpdate();
    }

    private void FixedUpdate()
    {
        MovementStateMachine.CurrentState.PhysicsUpdate();
    }

    public void ResetParams()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}


