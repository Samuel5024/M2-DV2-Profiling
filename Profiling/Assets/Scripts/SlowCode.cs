using System;
using UnityEngine;

public class SlowCode : MonoBehaviour
{
    private static readonly int ColorId = Shader.PropertyToID("_BaseColor");
    private Renderer targetRenderer;
    private MaterialPropertyBlock properties;
    private float timeValueRed;

    private float timeValueGreen;

    private float timeValueBlue;

    private void Awake()
    {
        targetRenderer = GetComponent<Renderer>();
        properties = new MaterialPropertyBlock();
    }

    private void Update()
    {
        float deltaTime = Time.deltaTime;
        timeValueRed = Mathf.Repeat(timeValueRed + deltaTime, 1f);
        timeValueGreen = Mathf.Repeat(timeValueGreen + deltaTime * 2f, 1f);
        timeValueBlue = Mathf.Repeat(timeValueBlue + deltaTime * 3f, 1f);
        
        properties.SetColor(ColorId, new Color(timeValueRed, timeValueGreen, timeValueBlue));
        targetRenderer.SetPropertyBlock(properties);
    }
}
