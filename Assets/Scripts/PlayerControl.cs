using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : Control
{
    public Joystick move_joystick;
    public Joystick shoot_joystick;

    void Start()
    {
    }

    void Update()
    {
        InputControl();
    }

    void InputControl()
    {
        if (move_joystick.Horizontal != 0 && move_joystick.Vertical != 0)
            Move(new Vector3(move_joystick.Horizontal, 0, move_joystick.Vertical));
        if (shoot_joystick.Horizontal != 0 && shoot_joystick.Vertical != 0)
            PlayManager.Instance.GetData().Main_Weapon.GetComponent<Weapon>().Shoot(new Vector3(shoot_joystick.Horizontal, 0, shoot_joystick.Vertical));

    }
    
}

