///////////////////////////////////////////////////////
// STM32 Pong Project - Léo Séry && Matthias Flament
// ####
// Script to manage the player paddle.
// script by Léo Séry - 26/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    public void FixedUpdate()
    {
        if (_direction.sqrMagnitude > 0)
        {
            _rigidBody.AddForce(_direction * speed);
        }
    }
}