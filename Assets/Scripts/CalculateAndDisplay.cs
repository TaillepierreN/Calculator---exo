using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateAndDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text screen;
    string screenNbr;
    string operation;
    int nbr1;
    int nbr2;
    int results;

    public void ButtonIsPressed(int btnNbr)
    {
        if (btnNbr < 10)
        {
            screenNbr += btnNbr;
            DisplayCurrentNbr();
        }
        else if (btnNbr == 10)
        {
            screenNbr = "";
            nbr1 = 0;
            nbr2 = 0;
        }
        else if (btnNbr == 11 && nbr1 != 0) Calculate();
        else if (btnNbr == 12)
        {
            SelectOperator("*");
        }
        else if (btnNbr == 13)
        {
            SelectOperator("+");
        }
        else if (btnNbr == 14)
        {
            SelectOperator("/");
        }
        else if (btnNbr == 15)
        {
            SelectOperator("-");
        }
    }
    void SelectOperator(string op)
    {
        if (nbr1 != 0)
        {
            Calculate();
        }
        if (nbr2 != 0)
        {
            nbr1 = nbr2;
            switch (op)
            {
                case "+": operation = "+"; break;
                case "*": operation = "*"; break;
                case "/": operation = "/"; break;
                case "-": operation = "-"; break;
            }
            nbr2 = 0;
            screenNbr = "";
        }
    }
    void Calculate()
    {
        switch (operation)
        {

            case "+":
                results = nbr1 + nbr2;
                break;
            case "*":
                results = nbr1 * nbr2;
                break;
            case "/":
                results = nbr1 / nbr2;
                break;
            case "-":
                results = nbr1 - nbr2;
                break;
        }
        screenNbr = results.ToString();
        nbr2 = results;
        nbr1 = 0;
        DisplayCurrentNbr();
    }
    void DisplayCurrentNbr()
    {
        nbr2 = int.Parse(screenNbr);
    }
    void Update()
    {
        if (screen.text != screenNbr) screen.text = screenNbr;
    }
}
