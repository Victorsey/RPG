using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp;
    public int str;
    public int dex;
    public int con;
    public int intel;
    public Rigidbody2D rb2d;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    void Movimento()
    {
        if(Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") == 0) { rb2d.AddForce(new Vector2(1 * speed, 0f)); }
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") > 0) { rb2d.AddForce(new Vector2(0f,1 * speed)); }
        if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") > 0) { rb2d.AddForce(new Vector2(1 * speed, 1*speed)); }
        if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") == 0) { rb2d.AddForce(new Vector2(-1 * speed, 0f)); }
        if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") > 0) { rb2d.AddForce(new Vector2(-1 * speed, 1 * speed)); }
        if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") < 0) { rb2d.AddForce(new Vector2(1 * speed, -1 * speed)); }
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") < 0) { rb2d.AddForce(new Vector2(0f, -1 * speed)); }
        if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") < 0) { rb2d.AddForce(new Vector2(-1 * speed, -1 * speed)); }
    }
}
