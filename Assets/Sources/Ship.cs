using System;
using System.Collections.Generic;

public class Ship
{
    private readonly Queue<Weapon> _weapons = new Queue<Weapon>();

    public void Add(Weapon weapon)
    {
        if (weapon == null)
            throw new ArgumentNullException(nameof(weapon));

        _weapons.Enqueue(weapon);
    }

    public void Fire(IDamageable target)
    {
        Weapon weapon = _weapons.Dequeue();
        _weapons.Enqueue(weapon);

        weapon.Shoot(target);
    }
}