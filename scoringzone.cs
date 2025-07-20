using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class scoringzone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoretrigger;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ball ball = collision.gameObject.GetComponent<ball>();
        if (ball != null)
        {
            BaseEventData eventdata = new BaseEventData(EventSystem.current);
            this.scoretrigger.Invoke(eventdata);
        }

    }
}
