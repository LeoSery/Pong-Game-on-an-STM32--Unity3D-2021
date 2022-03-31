///////////////////////////////////////////////////////
// STM32 Pong Project - Léo Séry && Matthias Flament
// ####
// Script to manage basic gameplay.
// script by Léo Séry - 26/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle adversaryPaddle;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI adversaryScoreText;

    public GameObject ScoreUI;
    public GameObject PaddlesUI;
    public GameObject CenterLineUI;
    public GameObject BallUI;

    private int _playerScore;
    private int _adversaryScore;

    private Menu MenuManager;

    public bool isInGame = false;

    public void Awake()
    {
        MenuManager = gameObject.GetComponent<Menu>();
    }

    public void PlayerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void AdversaryScore()
    {
        _adversaryScore++;
        adversaryScoreText.text = _adversaryScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        adversaryPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void LoadMainMenuUI()
    {
        MenuManager.MainMenuUI.SetActive(true);
        ScoreUI.SetActive(false);
        PaddlesUI.SetActive(false);
        CenterLineUI.SetActive(false);
        BallUI.SetActive(false);
    }

    public void LoadGameUI()
    {
        MenuManager.MainMenuUI.SetActive(false);
        ScoreUI.SetActive(true);
        PaddlesUI.SetActive(true);
        CenterLineUI.SetActive(true);
        BallUI.SetActive(true);
    }
    
    public void PrepareGameForAI()
    {
        adversaryPaddle.GetComponent<AIPaddle>().enabled = true;
        adversaryPaddle.GetComponent<AdversaryPaddle>().enabled = false;
    }

    public void PrepareGameForTwoPlayers()
    {
        adversaryPaddle.GetComponent<AIPaddle>().enabled = false;
        adversaryPaddle.GetComponent<AdversaryPaddle>().enabled = true;
    }
}