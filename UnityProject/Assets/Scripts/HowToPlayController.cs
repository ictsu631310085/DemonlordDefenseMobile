using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayController : MonoBehaviour
{
    public Texture[] howToTexture;

    public RawImage howToDisplay;

    public int howToIndex;

    // Start is called before the first frame update
    void Start()
    {
        howToDisplay.texture = howToTexture[howToIndex];
    }

    public void PreviousButton()
    {
        if (howToIndex == 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            howToIndex--;
            howToDisplay.texture = howToTexture[howToIndex];
        }
    }

    public void NextButton()
    {
        if (howToIndex == howToTexture.Length - 1)
        {
            howToIndex = 0;
            gameObject.SetActive(false);
        }
        else
        {
            howToIndex++;
        }

        howToDisplay.texture = howToTexture[howToIndex];
    }
}
