using System.Collections;
using UnityEngine;

public class MoveProgressLine : MonoBehaviour
{
    [SerializeField] private RectTransform progressLine; 
    [SerializeField] private float fixedDistanceX = 100f;
    [SerializeField] private float speed = 1f;
    public void MoveProgress()
    {
        
        StartCoroutine(SmoothMove());
    }

    private IEnumerator SmoothMove()
    {
        float targetDistance = progressLine.position.x + fixedDistanceX;
        while (Mathf.Abs(targetDistance - progressLine.position.x) < 0.1f)
        {
            Mathf.Lerp(progressLine.position.x, fixedDistanceX, speed*Time.deltaTime);
            yield return null;
        }
        
        progressLine.position = new Vector2(fixedDistanceX, progressLine.position.y);
    } 
}
