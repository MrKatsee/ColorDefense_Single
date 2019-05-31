using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : CharacterData
{
    private Weapon main_Weapon;
    public Weapon Main_Weapon
    {
        get { return main_Weapon; }
        set
        {
            main_Weapon = value;
            //그 외 UI 적인 부분
        }
    }
    private Weapon sub_Weapon;
    public Weapon Sub_Weapon
    {
        get { return sub_Weapon; }
        set
        {
            sub_Weapon = value;
            //그 외 UI 적인 부분
        }
    }

    void Start()
    {

    }

    public void ChangeWeapon()
    {
        //box와 겹친 경우 -> sub / drop 간 교환
        //이 때, 주운 무기를 Init 해줘야함
        //아닌 경우 -> main / sub 간 교환
        Weapon temp = Main_Weapon;
        Main_Weapon = Sub_Weapon;
        Sub_Weapon = temp;
    }
}
