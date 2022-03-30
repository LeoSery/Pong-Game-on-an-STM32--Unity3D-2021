///////////////////////////////////////////////////////
// STM32 Pong Project - Léo Séry && Matthias Flament
// ####
// Script to manage the paddle base class.
// script by Léo Séry - 26/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidBody.position = new Vector2(_rigidBody.position.x, 0.0f);
        _rigidBody.velocity = Vector2.zero;
    }
}