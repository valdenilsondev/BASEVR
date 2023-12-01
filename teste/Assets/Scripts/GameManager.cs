using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Image imageFade;
	// Use this for initialization
	void Start () {
		Invoke("fade", 1);
	}
	
	private void fade()
    {
		imageFade.CrossFadeAlpha(0, 2, true);
	}
}
