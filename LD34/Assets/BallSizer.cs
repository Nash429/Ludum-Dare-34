using UnityEngine;
using System.Collections;

public class BallSizer : MonoBehaviour {

    [SerializeField]
    private float BallDiameter = 1.0f;

    [SerializeField]
    private float BallMass = 5.0f;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.mass = BallMass;
        transform.localScale = new Vector3(BallDiameter, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
