using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    public TextMeshProUGUI InputField;
    public TextMeshProUGUI AnswerField;
    string viewText, tempText, appliedOpt;
    float input_1;
    float input_2;

    bool isOperApplied = false;
    

    public AudioSource buttonAudio;

    private void Start()
    {
        InputField.text = "0";
    }

     #region Buttons
    public void Button_1()
    {
        buttonAudio.Play();

        viewText = viewText + "1";
        InputField.text = viewText.ToString();
        
        if (isOperApplied)
        {
            tempText = tempText + "1";
        }

       
    }
    public void Button_2()
    {

        buttonAudio.Play();
        viewText = viewText + "2";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "2";
        }
    }
    public void Button_3()
    {

        buttonAudio.Play();
        viewText = viewText + "3";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "3";
        }
    }
    public void Button_4()
    {

        buttonAudio.Play();
        viewText = viewText + "4";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "4";
        }
    }
    public void Button_5()
    {

        buttonAudio.Play();
        viewText = viewText + "5";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "5";
        }
    }
    public void Button_6()
    {

        buttonAudio.Play();
        viewText = viewText + "6";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "6";
        }
    }
    public void Button_7()
    {

        buttonAudio.Play();
        viewText = viewText + "7";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "7";
        }
    }
    public void Button_8()
    {

        buttonAudio.Play();
        viewText = viewText + "8";
        InputField.text = viewText.ToString();
        if (isOperApplied)
        {
            tempText = tempText + "8";
        }
    }
    public void Button_9()
    {

        buttonAudio.Play();
        viewText = viewText + "9";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "9";
        }
    }
    public void Button_0()
    {
        buttonAudio.Play();
        viewText = viewText + "0";
        InputField.text = viewText.ToString();

        if (isOperApplied)
        {
            tempText = tempText + "0";
        }
    }
    #endregion Buttons

    #region Operations
    public void Button_Plus(string opr)
    {
        buttonAudio.Play();
        input_1 = System.Convert.ToInt32(viewText.ToString());

        if(opr == "+")
        {
           
            viewText = viewText + "+";
            appliedOpt = "+";
        }
        else if (opr == "-")
        {
            
            viewText = viewText + "-";
            appliedOpt = "-";
        }
        else if(opr == "x")
        {
           
            viewText = viewText + "x";
            appliedOpt = "x";
        }
        else if (opr == "/")
        {
            
            viewText = viewText + "/";
            appliedOpt = "/";
        }

        isOperApplied = true;
        InputField.text = viewText.ToString();
        
    }

    public void Button_Equals()
    {

        buttonAudio.Play();
        input_2 = System.Convert.ToInt32(tempText.ToString());

        if(appliedOpt == "+")
        {
            AnswerField.text = (input_1 + input_2).ToString();
        }
        else if(appliedOpt == "-")
        {
            AnswerField.text = (input_1 - input_2).ToString();
        }
        else if (appliedOpt == "x")
        {
            AnswerField.text = (input_1 * input_2).ToString();
        }
        else if (appliedOpt == "/")
        {
            AnswerField.text = (input_1 / input_2).ToString();
        }
    }

    public void Button_Clear()
    {

        buttonAudio.Play();
        viewText = tempText = appliedOpt = null;
        input_1 = input_2 = 0;
        isOperApplied = false;

        InputField.text = "0";
        AnswerField.text = "0";
    }

  

    #endregion Operations

}
