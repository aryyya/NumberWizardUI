using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] Text guessText;

    int min;
    int max;
    int guess;
    int maxGuesses;

    void Start()
    {
        Initialize();
        ShowGuess();
    }

    void Update()
    {
    }

    void Initialize()
    {
        min = 1;
        max = 1000 + 1;
        maxGuesses = 10;
        SetGuess();
    }

    void SetGuess(string guessDistance = "")
    {
        if /**/ (guessDistance == "hi") max = guess;
        else if (guessDistance == "lo") min = guess;
        guess = (max + min) / 2;

        maxGuesses -= 1;
        if (maxGuesses <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void ShowGuess()
    {
        guessText.text = "Is your number " + guess + "?";
    }

    public void GuessIsHi()
    {
        SetGuess("hi");
        ShowGuess();
    }

    public void GuessIsLo()
    {
        SetGuess("lo");
        ShowGuess();
    }

    public void GuessIsCorrect()
    {
        SceneManager.LoadScene("Lose");
    }
}
