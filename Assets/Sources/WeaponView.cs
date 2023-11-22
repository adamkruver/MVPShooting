using Sources;
using UnityEngine;

public class WeaponView : MonoBehaviour, IWeaponView
{
    private WeaponPresenter _presenter;

    private void OnEnable() => 
        _presenter?.Enable();

    private void OnDisable() =>
        _presenter?.Disable();

    public Vector3 Position => transform.position;
    
    public void Construct(WeaponPresenter presenter)
    {
        gameObject.SetActive(false);
        _presenter = presenter;
        gameObject.SetActive(true);
    }

    public void Shoot()
    {
        Debug.Log("Shoot");
    }
}