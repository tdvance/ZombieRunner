using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour {

    public float zoomSpeed = 60f;
    public float zoomAmount = 2f;

    private Camera eyes;
    private float defaultFOV;


    // Use this for initialization
    void Start() {
        eyes = GetComponent<Camera>();
        defaultFOV = eyes.fieldOfView;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Zoom") > 0) {
            Zoom();
        } else {
            RestoreFOV();
        }
    }

    void Zoom() {
        if (eyes.fieldOfView > defaultFOV / zoomAmount) {
            eyes.fieldOfView -= Time.deltaTime * zoomSpeed;
        }
        if (eyes.fieldOfView < defaultFOV / zoomAmount) {
            eyes.fieldOfView = defaultFOV / zoomAmount;
        }
    }

    void RestoreFOV() {
        if (eyes.fieldOfView < defaultFOV) {
            eyes.fieldOfView += Time.deltaTime * zoomSpeed;
        }
        if (eyes.fieldOfView > defaultFOV) {
            eyes.fieldOfView = defaultFOV;
        }
    }
}
