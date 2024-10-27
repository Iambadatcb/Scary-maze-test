using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector3 playerPos;
    private Camera mainCamera;
    private Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible=false;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(playerPos);
    }
    private void OnCollisionEnter(Collision other) 
{
    if(other.gameObject.tag == "Death")
    {
        print("Game Over");
        
    }
}
}
