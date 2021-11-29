using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    public static readonly string[] staticDirections = { "Iddle"//ANIMACIONES ESTÁTICAS};

    };

    public static readonly string[] runDirections = {"Walk" //ANIMACIONES CARRERA};
    };

    Animator animator;
    int lastDirection;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetDirection(Vector2 direction)
    {

        //animaciones de carrera predefinida
        string[] directionArray = null;


        if (direction.magnitude < .01f)
        {
            directionArray = staticDirections;


        }
        else
        {
            directionArray = runDirections;
            lastDirection = DirectionToIndex(direction, 8);

        }

        animator.Play(lastDirection);

    }

    public static int DirectionToIndex (Vector2 dir, int sliceCount)
   
    {
        Vector2 normDir = dir.normalized;
        float step = 360f / sliceCount;
        float halfStep = step / 2;
        float angle = Vector2.SignedAngle(Vector2.up, normDir);
        angle += halfStep;

        if (angle < 0)
        {
            angle += 360;
                
                
        }
        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);


    }
}
