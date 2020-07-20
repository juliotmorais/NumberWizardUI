using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessedNumber;
    [SerializeField] Button higher;
    [SerializeField] Button lower;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHigher()
    {
        min = guess+1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess-1;
        NextGuess();
    }

    void StartGame()
    {

        NextGuess();


        higher.onClick.AddListener(OnPressHigher);
        lower.onClick.AddListener(OnPressLower);
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        guessedNumber.text = guess.ToString();
    }


}
