using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerController _playerController;
    private InputHandler _inputHandler;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _playerController = GetComponent<PlayerController>();
        _inputHandler = GetComponent<InputHandler>();
    }

    void Update()
    {
        if (_playerController.stage == "OnPlanet")
        {
            if (_inputHandler.horizontal != 0)
            {
                _animator.SetBool("isWalking", true);
            }
            else
            {
                _animator.SetBool("isWalking", false);
            }
        }

        if (_playerController.stage == "OnPlanet")
        {
            if (_inputHandler.w)
            {
                _animator.SetBool("isTransforming", true);
            }
            else
            {
                _animator.SetBool("isTransforming", false);
            }
        }

    }
}