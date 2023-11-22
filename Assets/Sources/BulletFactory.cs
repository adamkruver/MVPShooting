using UnityEngine;

namespace Sources
{
    public class BulletFactory : MonoBehaviour
    {
        [SerializeField] private Bullet _bulletPrefab;

        public Bullet Create(Vector3 startPosition) => 
            Instantiate(_bulletPrefab, startPosition, Quaternion.identity);
    }
}