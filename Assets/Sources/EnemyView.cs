using UnityEngine;

namespace Sources
{
    public class EnemyView : MonoBehaviour, IDamageable
    {
        public void TakeDamage(float damage)
        {
        }

        public Vector3 Position => transform.position;
    }
}