using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour
{
    public List<Text> TextToFade = new List<Text>();
    public float TextFadeDuration = 50.00f;

    // Start is called before the first frame update
    void Start()
    {
        Text text = GetComponent<Text>();
        StartCoroutine(FadeInText(TextFadeDuration, text));
    }

    // Update is called once per frame
    void Update()
    {
        //Text text = GetComponent<Text>();

        //text.CrossFadeAlpha(0f, 15f, false);
    }

    private IEnumerator FadeOutRoutine()
    {
        Text text = GetComponent<Text>();
        Color originalColor = text.color;
        for (float t = 0.01f; t < TextFadeDuration; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / TextFadeDuration));
            yield return null;
        }
    }

    private IEnumerator FadeInText(float timeSpeed, Text text)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime * timeSpeed));
            yield return null;
        }

    }
}
