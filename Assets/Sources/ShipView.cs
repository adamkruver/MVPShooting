using Sources;
using UnityEngine;

public class ShipView : MonoBehaviour, IShipView
{
    [field: SerializeField] public WeaponView Weapon1 { get; private set; }
    [field: SerializeField] public WeaponView Weapon2 { get; private set; }
    
    private ShipPresenter _presenter;

    public void Construct(ShipPresenter presenter) => 
        _presenter = presenter;

    public void Fire(IDamageable target) => 
        _presenter?.Fire(target);
}