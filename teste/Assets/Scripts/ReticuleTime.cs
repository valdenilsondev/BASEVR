using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class ReticuleTime : MonoBehaviour {

	public Image imgTime;
	public float timeTotal;
	public float timeCorrent;
	public bool isAtivo;

	public UnityEvent[] timeEvents;
	public int idEvent;
	// Use this for initialization
	void Start () {
		Time_Exit();
	}
	
	// Update is called once per frame
	void Update () {
		time();
	}
	private void time()
    {
        if (isAtivo)
        {
			timeCorrent += Time.deltaTime;
			imgTime.fillAmount = timeCorrent/timeTotal;
			if(timeCorrent >= timeTotal)
            {
				isAtivo = false;
				timeEvents[idEvent].Invoke();
            }
        }
    }
	public void Time_Enter(int _ID)
	{
		isAtivo = true;
		idEvent = _ID;
    }
	public void Time_Exit()
    {
		isAtivo = false;
		imgTime.fillAmount = 0;
		timeCorrent = 0;
    }
}
