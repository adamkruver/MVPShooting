using System;

public class Weapon
{
    private readonly float _damage;

    public Weapon(float damage)
    {
        if (damage <= 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        _damage = damage;
    }

    public event Action<IDamageable> Shooting;

    public void Shoot(IDamageable target)
    {
        target.TakeDamage(_damage);
        Shooting?.Invoke(target);
    }
}