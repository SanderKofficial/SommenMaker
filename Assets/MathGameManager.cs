using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MathGameManager : MonoBehaviour
{

    public float restartDelay = 2f;
    //Eerste value
    private int lowFirstValue = 0;
    private int highFirstValue = 100;
    public int firstValue;
    //Tweede value
    private int lowSecondValue = 0;
    private int highSecondValue = 20;
    public int SecondValue;
    public Text somTxt;
    public Text antwoordTxt;
    public int FinalValue;
    public int WrongValue;
    private bool isAdd = false;
    private bool isSub = false;
    private bool isMulti = false;
    private bool isDiv = false;



    void Start()
    {
        firstValue = Random.Range(lowFirstValue, highFirstValue);
        SecondValue = Random.Range(lowSecondValue, highSecondValue);
        var i = Random.Range(1, 4);

        if (i == 1)
        {
            FinalValue = firstValue + SecondValue;
            Debug.Log("Plus Som");
            isAdd = true;
        }
        if (i == 2)
        {
            FinalValue = firstValue - SecondValue;
            Debug.Log("Min Som");
            isSub = true;
        }
        if (i == 3)
        {
            FinalValue = firstValue * SecondValue;
            Debug.Log("Keer Som");
            isMulti = true;
        }
        if (i == 4)
        {
            FinalValue = firstValue / SecondValue;
            Debug.Log("Deel Som");
            isDiv = true;
        }


    }

    void Update()
    {

        if (isAdd == true)
        {
            somTxt.text = firstValue + "+" + SecondValue.ToString();
        }
        if (isSub == true)
        {
            somTxt.text = firstValue + "-" + SecondValue.ToString();
        }
        if (isMulti == true)
        {
            somTxt.text = firstValue + "x" + SecondValue.ToString();
        }
        if (isDiv == true)
        {
            somTxt.text = firstValue + "/" + SecondValue.ToString();
        }

    }
    private string input;
    public void EndAnswer(string answerString)
    {
        input = answerString;
        int answerValue;
        int.TryParse(input, out answerValue);
        if (answerValue == FinalValue)
        {
            Debug.Log("CORRECT");

            antwoordTxt.text = FinalValue.ToString("Correct");

        

        }
        else
        {
            Debug.Log("FOUT");
            antwoordTxt.text = WrongValue.ToString("Fout");

        }
        Debug.Log(input);
    }

}
