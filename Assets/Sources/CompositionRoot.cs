using System.Collections;
using Sources;
using UnityEngine;

public class CompositionRoot : MonoBehaviour
{
    [SerializeField] private float _fireCooldown = .5f;
    [SerializeField] private EnemyView _enemyView;
    [SerializeField] private BulletFactory _bulletFactory;
    
    private WaitForSeconds _fireDelay;

    private void Awake()
    {
        _fireDelay = new WaitForSeconds(_fireCooldown);
    }

    private IEnumerator Start()
    {
        Ship ship = new Ship();
        Weapon weapon1 = new Weapon(10);
        Weapon weapon2 = new Weapon(20);
        
        ship.Add(weapon1);
        ship.Add(weapon2);

        ShipView shipView = FindObjectOfType<ShipView>();
        shipView.Construct(new ShipPresenter(shipView, ship));
        
        WeaponView weaponView1 = shipView.Weapon1;
        WeaponView weaponView2 = shipView.Weapon2;
        
        weaponView1.Construct(new WeaponPresenter(weaponView1, weapon1, _bulletFactory));
        weaponView2.Construct(new WeaponPresenter(weaponView2, weapon2, _bulletFactory));
        
        yield return StartFire(shipView);
    }

    private IEnumerator StartFire(ShipView shipView)
    {
        while (true)
        {
            shipView.Fire(_enemyView);
            
            yield return _fireDelay;
        }
    }
}
