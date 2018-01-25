using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothing = 5f;
    public int screenshotNum = 0;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - target.position;
	}
	
	// Using fixed update since player is moving using fixed update
	void FixedUpdate () {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

        if(Input.GetKeyDown("e")) {
            ScreenCapture.CaptureScreenshot("Screenshot" + screenshotNum + ".png");
            screenshotNum++;
        }
    }

}
