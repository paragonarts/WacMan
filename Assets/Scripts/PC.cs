using UnityEngine;
using System.Collections;

public class PC : MonoBehaviour {
    Vector2 MovementDirection;
    public float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Transform>().Translate(MovementDirection * Speed, Space.World);
	}
    public void MoveVertical(int VerticalAxis)
    {
        MovementDirection.y = VerticalAxis;
    }
    public void MoveHorizontal(int HorizontalAxis)
    {
        MovementDirection.x = HorizontalAxis;
    }
}
