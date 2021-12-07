using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text GetWord;

    public UnityEngine.UI.Text GetGuessedLetters;

    public UnityEngine.UI.Text GuessesLeft;
    public UnityEngine.UI.Text CheckGuess;
    
    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
        GetWord.text = this.guessingGame.GetWord();

    }
    
    public void OpenStartScreen()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
        this.StartButton.gameObject.SetActive(true);
    }

    public void Start()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
    }

    public void SubmitGuess()
    {
        
        Debug.Log(this.guessingGame.CheckGuess(PlayerGuess.text));
        PlayerGuess.text = string.Empty; 
        GetWord.text = this.guessingGame.GetWord();
        GetGuessedLetters.text = this.guessingGame.GetGuessedLetters();
        CheckGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        GuessesLeft.text = $"{this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses()}";
        
        
    }








}



