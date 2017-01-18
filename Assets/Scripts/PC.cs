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
    public void MoveHorizontal(int HorizontalAxis)
    {
        if (HorizontalAxis == 0)
        {
            MovementDirection.x = HorizontalAxis;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else { MovementDirection.x = HorizontalAxis; }
        
    }
}
