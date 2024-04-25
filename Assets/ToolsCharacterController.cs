using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsCharacterController : MonoBehaviour
{
    CharacterController2d character;
    Rigidbody2D rgbd2d;
    [SerializeField] float offsetDistance = 1f;
    [SerializeField] float sizeOfInteracatbleArea = 1.2f;
    private void Awake()
    {
        character = GetComponent<CharacterController2d>();
        rgbd2d = GetComponent<Rigidbody2D>();
    
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UseTool();
        }
       
    }
    
    private void UseTool()
    {
        Vector2 position = rgbd2d.position + character.lastMotionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteracatbleArea);

        foreach (Collider2D c in colliders)
        {
            ToolHit hit= c.GetComponent<ToolHit>();
            if (hit != null)
            {
                hit.Hit();
                break;
            }
        }
    }
}
