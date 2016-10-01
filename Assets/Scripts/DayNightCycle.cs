using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {

    private float sunXangle;
    private float sunYangle;
    private float sunZangle;

    private Quaternion startRotation;

    [Tooltip("Set number of minutes that pass per second")]
    public float timeScale = 1f;


    // Use this for initialization
    void Start() {
        startRotation = transform.rotation;
        sunXangle = transform.rotation.eulerAngles.x;
        sunYangle = transform.rotation.eulerAngles.y;
        sunZangle = transform.rotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update() {
        float angle = Time.deltaTime / 60 * timeScale;
        transform.Rotate(Vector3.right, angle);
    }
}
