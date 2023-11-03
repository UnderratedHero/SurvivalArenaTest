using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour
{
    [SerializeField] private List<GameObject> _weapons;
    private int _weaponIndex;

    public GameObject CurrentWeapon { get; private set; }
    
    private void Start()
    {
        foreach(var weapon in _weapons)
        {
            weapon.SetActive(false);
        }
        CurrentWeapon = _weapons[_weaponIndex];
        CurrentWeapon.SetActive(true);
    }

    public void Change()
    {
        if (_weaponIndex == _weapons.Count - 1)
        {
            ReloadWeaponsArray();
            return;
        }
        CurrentWeapon.SetActive(false);
        _weaponIndex++;
        CurrentWeapon = _weapons[_weaponIndex];
        CurrentWeapon.SetActive(true);
    }
    

    private void ReloadWeaponsArray()
    {
        CurrentWeapon.SetActive(false);
        _weaponIndex = 0;
        CurrentWeapon = _weapons[_weaponIndex];
        CurrentWeapon.SetActive(true);
    }
}
