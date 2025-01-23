using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour,IDragHandler ,IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    [SerializeField] private RectTransform targetTransform;
    private float snapDistance = 20f;
    [SerializeField] private float moveSpeed = 10f;
    public bool isSnapped = false;
    public UnityAction onSnapCompleted;

    private void Start() 
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {   
        if (isSnapped) return;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isSnapped) return;
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Vector2.Distance(rectTransform.position, targetTransform.position) <= snapDistance)
        {
            StartCoroutine(SmoothMove());
        }
    }

    private IEnumerator SmoothMove()
    {   
        while(Vector2.Distance(rectTransform.position, targetTransform.position) > 0.1f)
        {
            rectTransform.position = Vector2.Lerp(rectTransform.position, targetTransform.position, moveSpeed*Time.deltaTime);
            rectTransform.rotation = Quaternion.Lerp(rectTransform.rotation, targetTransform.rotation, moveSpeed*Time.deltaTime);
            yield return null;
        }
        
        rectTransform.position = targetTransform.position;
        
        isSnapped = true;
        onSnapCompleted?.Invoke();
        
    }
}


