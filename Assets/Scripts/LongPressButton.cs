using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LongPressButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public BallPitch ballPitch;

    private bool isButtonHeldDown = false;
    private float timeHeldDown = 0f;

    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonHeldDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ballPitch.LongPressButtonReleased(timeHeldDown);
        isButtonHeldDown = false;
        timeHeldDown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isButtonHeldDown)
        {
            timeHeldDown += Time.deltaTime;
        }
    }
}
