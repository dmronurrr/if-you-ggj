using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableText : MonoBehaviour
{
    public string textString;
    public Text text;
    public void Interact()
    {
        text.gameObject.SetActive(true);
        text.text=textString;
        StartCoroutine(nameof(Wait));
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        text.text="";
        text.gameObject.SetActive(false);
    }
}
