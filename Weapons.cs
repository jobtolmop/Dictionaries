using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public Dictionary<weapon, int> Ammo = new Dictionary<weapon, int>();

    public weapon aWeapon;
    public int AmmoLeft;

    public enum weapon { Sniper, Sub, Melee };

    void Start()
    {
        Ammo.Add(weapon.Sniper, 28);
        Ammo.Add(weapon.Sub, 120);
        Ammo.Add(weapon.Melee, 2);
    }

    void Update()
    {
        AmmoLeft = Ammo[aWeapon];

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (aWeapon == weapon.Sniper)
            {
                aWeapon = weapon.Sub;
            }
            else
            {
                if (aWeapon == weapon.Sub)
                {
                    aWeapon = weapon.Melee;
                }
                
                else
                {
                    if (aWeapon == weapon.Melee)
                    {
                        aWeapon = weapon.Sniper;                   
                    }
                }
            }
        }

        if (Input.GetKey(KeyCode.Space))       
        {
            if (aWeapon == weapon.Sniper)
            {
                Debug.Log("Sniper: " + Ammo[weapon.Sniper]);
                Ammo[weapon.Sniper] = Ammo[weapon.Sniper] -= 1;
            }
            else
            {
                if (aWeapon == weapon.Sub)
                {
                    Debug.Log("SubMachineGun: " + Ammo[weapon.Sub]);
                    Ammo[weapon.Sub] = Ammo[weapon.Sub] -= 6;
                }
                else
                {
                    if (aWeapon == weapon.Melee)
                    {
                        Debug.Log("Melee (Balistic Knife): " + Ammo[weapon.Melee]);
                        Ammo[weapon.Melee] = Ammo[weapon.Melee] -= 1;
                    }
                }
            }
        }
    }
}
