using UnityEngine;

using UnityEngine.EventSystems;

public class HandleScript : MonoBehaviour, IPointerDownHandler

{

    public void OnPointerDown(PointerEventData eventData)

    {

        Debug.Log(eventData.position);

    }

}