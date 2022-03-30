///////////////////////////////////////////////////////
// STM32 Pong Project - Léo Séry && Matthias Flament
// ####
// Script to manage game score.
// script by Léo Séry - 26/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(eventData);
        }
    }
}
