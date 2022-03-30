///////////////////////////////////////////////////////
// STM32 Pong Project - Léo Séry && Matthias Flament
// ####
// Script that manages bounce surfaces.
// script by Léo Séry - 26/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * bounceStrength);
        }
    }
}
