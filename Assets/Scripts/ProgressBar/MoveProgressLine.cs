using System.Collections;
using UnityEngine;

public class MoveProgressLine : MonoBehaviour
{
    [SerializeField] private RectTransform progressLine; 
    [SerializeField] private float speed = 1f;
    public void MoveProgress(float fixedDistanceX)
    {
        StartCoroutine(SmoothMove(fixedDistanceX));
    }

     private IEnumerator SmoothMove(float fixedDistanceX)
    {
        float targetPositionX = progressLine.anchoredPosition.x + fixedDistanceX;

        while (Mathf.Abs(targetPositionX - progressLine.anchoredPosition.x) > 0.1f)
        {
            float newX = Mathf.Lerp(progressLine.anchoredPosition.x, targetPositionX, speed * Time.deltaTime);
            progressLine.anchoredPosition = new Vector2(newX, progressLine.anchoredPosition.y);
            yield return null;
         
        }
 
        progressLine.anchoredPosition = new Vector2(targetPositionX, progressLine.anchoredPosition.y);
        
    }

    
}



