using System;
using JetBrains.Annotations;

namespace Sources
{
    public class WeaponPresenter
    {
        private readonly IWeaponView _view;
        private readonly Weapon _weapon;
        private readonly BulletFactory _bulletFactory;

        public WeaponPresenter([NotNull] IWeaponView view, [NotNull] Weapon weapon, BulletFactory bulletFactory)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
            _bulletFactory = bulletFactory;
        }

        public void Enable() => 
            _weapon.Shooting += OnShooting;

        public void Disable() => 
        _weapon.Shooting -= OnShooting;

        private void OnShooting(IDamageable target)
        {
            _view.Shoot();
            Bullet bullet = _bulletFactory.Create(_view.Position);
            bullet.Move(target.Position);
        }
    }
}