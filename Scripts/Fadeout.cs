using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fadeout : MonoBehaviour {

    public Color color;
    public Image img;

    private void Start()
    {
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut()
    {
        
        while (color.a < 1f)
        {
            color.a += 0.01f;
            img.color = color;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
