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
        max = 100 + 1;
        SetGuess();
    }

    void SetGuess(string guessDistance = "")
    {
        if /**/ (guessDistance == "hi") max = guess;
        else if (guessDistance == "lo") min = guess;
        guess = (max + min) / 2;
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
        SceneManager.LoadScene("Win");
    }
}
