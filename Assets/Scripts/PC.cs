using UnityEngine;
using System.Collections;

public class PC : MonoBehaviour {
    Vector2 MovementDirection;
    public float Speed;
    public float JumpHeight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(MovementDirection * Speed, ForceMode2D.Impulse);
	}
    public void MoveVertical(int VerticalAxis)
    {
        if (VerticalAxis == 0)
        {
            MovementDirection.y = VerticalAxis;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else { MovementDirection.y = VerticalAxis; }
        
    }
    public void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpHeight, ForceMode2D.Impulse);
    }
}
