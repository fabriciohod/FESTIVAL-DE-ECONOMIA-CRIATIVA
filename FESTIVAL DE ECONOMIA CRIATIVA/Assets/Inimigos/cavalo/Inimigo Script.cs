using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(EntityComponet), typeof(LifeSysteam))]
public class InimigoScript : MonoBehaviour
{
    [SerializeField] private Transform pontoA;
    [SerializeField] private Transform pontoB;
    private Vector3 a;
    private Vector3 b;

    private void Start()
    { 
        a = new Vector3(pontoA.position.x, pontoA.position.y, 0 );
        b = new Vector3(pontoB.position.x, pontoB.position.y, 0 );
    }

    void Update()
    {
        
    }

    private void AndarEtrePontos(Transform PontoA, Transform PontosB)
    {
        Vector3 thisPosition = new Vector3 (transform.position.x, 0, 0);
        bool isRight;
        if (isRight) {
            transform.position = Vector3.MoveTowards (transform.position, pointB.position, speed);
            if (thisPosition.Equals (pointBPosition)) {
                //Debug.Log ("Position b");
                isRight = false;
            } 
        } else {
            transform.position = Vector3.MoveTowards (transform.position, pointA.position, speed);
            if (thisPosition.Equals (pointAPosition)) {
                //Debug.Log ("Position a");
                isRight = true;
    }
}
