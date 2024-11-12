using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    private RectTransform rectTransform;
    private float loadingDuration = 2f;
    private float loadingProgress = 0f;
    private float maxWidth = 1920f;
    private bool isLoading = false;

    public bool IsLoadingComplete { get; private set; }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        IsLoadingComplete = false;
    }

    public void StartLoading()
    {
        loadingProgress = 0f;
        isLoading = true;
        IsLoadingComplete = false;
    }

    public void UpdateLoading()
    {
        if (isLoading)
        {
            loadingProgress += Time.deltaTime / loadingDuration;
            UpdateLoadingBar(loadingProgress);

            if (loadingProgress >= 1f)
            {
                isLoading = false;
                IsLoadingComplete = true;
                Debug.Log("Loading Complete!");
            }
        }
    }

    private void UpdateLoadingBar(float _progress)
    {
        if (rectTransform != null)
        {
            rectTransform.sizeDelta = new Vector2(maxWidth * _progress, rectTransform.sizeDelta.y);
        }
    }
}
