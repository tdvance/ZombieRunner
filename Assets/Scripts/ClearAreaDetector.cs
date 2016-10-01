using UnityEngine;
using System.Collections;

public class ClearAreaDetector : MonoBehaviour {
    public AudioClip clip;

    public float timeSinceLastTrigger = 0;
    public bool clearAreaFound = false;
    Vector3 clearAreaLocation;
    int enterCount = 0;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (enterCount > 0) {
            timeSinceLastTrigger = 0;
        }
        if (!clearAreaFound && timeSinceLastTrigger > 1) {
            clearAreaFound = true;
            clearAreaLocation = transform.position;
            AudioSource.PlayClipAtPoint(clip, clearAreaLocation);
        } else {
            timeSinceLastTrigger += Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider collider) {
        timeSinceLastTrigger = 0;
        enterCount++;
    }

    void OnTriggerExit(Collider collider) {
        enterCount--;
    }

}
