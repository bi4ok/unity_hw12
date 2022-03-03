using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(MovementControl))]
    public class PlayerControl : MonoBehaviour
    {
        private Vector3 _playerPosition;
        private MovementControl _playerMove;
        private Animator _playerAnimation;
        private Rigidbody _playerBody;

        private void Awake()
        {
            _playerMove = GetComponent<MovementControl>();
            _playerAnimation = GetComponent<Animator>();
            _playerBody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _playerPosition = new Vector3(Input.GetAxis(PlayerInputs.HORIZONTAL_AXIS), 0.0f, Input.GetAxis(PlayerInputs.VERTICAL_AXIS));
            _playerAnimation.SetFloat("Velocity", _playerBody.velocity.magnitude);

        }

        private void FixedUpdate()
        {
            _playerMove.MoveHorizontal(_playerPosition);
        }


    }

}
