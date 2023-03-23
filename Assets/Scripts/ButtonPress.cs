using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    [SerializeField] int btnNbr;
    [SerializeField] GameObject button;
    [SerializeField] CalculateAndDisplay screen;

    public void IsPressed()
    {
        screen.ButtonIsPressed(btnNbr);
        StartCoroutine(AnimButton());
    }
    IEnumerator AnimButton()
    {
        button.gameObject.transform.position -= new Vector3(0.1f,0,0);
        yield return new WaitForSeconds(0.1f);
        button.gameObject.transform.position -= new Vector3(-0.1f,0,0);

    }
}
