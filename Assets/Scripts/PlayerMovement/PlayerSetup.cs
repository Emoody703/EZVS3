using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public PlayerMotor movement;
    public InputManager input;

    public GameObject camera;

    public void IsLocalPlayer()
{
    movement.enabled = true;
    input.enabled = true;
    camera.SetActive(true);
}}
