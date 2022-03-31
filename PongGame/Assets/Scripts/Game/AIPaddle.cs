///////////////////////////////////////////////////////
// STM32 Pong Project - Léo Séry && Matthias Flament
// ####
// Script to manage the AI paddle.
// script by Léo Séry - 26/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;

public class AIPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0.0f)
        {
            if (ball.position.y > transform.position.y)
                _rigidBody.AddForce(Vector2.up * speed);
            else if (ball.position.y < transform.position.y)
            _rigidBody.AddForce(Vector2.down * speed);
        }
        else
        {
            if (transform.position.y > 0.0f)
                _rigidBody.AddForce(Vector2.down * speed);
            else if (transform.position.y < 0.0f)
                _rigidBody.AddForce(Vector2.up * speed);
        }
    }
}
