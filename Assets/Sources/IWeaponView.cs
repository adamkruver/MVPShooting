using UnityEngine;

namespace Sources
{
    public interface IWeaponView
    {
        public void Shoot();
        Vector3 Position { get; }
    }
}