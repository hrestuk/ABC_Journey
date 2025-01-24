using System.Collections;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float fadeDuration = 1f;
    [SerializeField] private GameObject blackBackground;

    public void ShowLoadingScreen()
    {
        canvasGroup.alpha = 0f;
        StartCoroutine(FadeIn());
    }

    public void HideLoadingScreen()
    {
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeIn()
    {   
        canvasGroup.blocksRaycasts = true;

        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            yield return null;
        }
        yield return new WaitForSeconds(2f);
        blackBackground.SetActive(false);
        HideLoadingScreen();
    }

    private IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = 1f - Mathf.Clamp01(elapsedTime / fadeDuration);
            yield return null;
        }

        canvasGroup.blocksRaycasts = false;
        FindObjectOfType<LevelLoader>()?.CompleteLoading();
    }
}
