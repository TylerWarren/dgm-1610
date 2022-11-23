using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent,RepeatUntilFalseEvent;
 {
    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
 
    private void Start()
    {
        startEvent.Invoke();
    }
 
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
 
    private IEnumerator Counting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }
 
    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
 
 
    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            RepeatUntilFalseEvent.Invoke();
        }
 
    }
}