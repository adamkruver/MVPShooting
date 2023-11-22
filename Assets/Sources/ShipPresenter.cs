namespace Sources
{
    public class ShipPresenter
    {
        private readonly IShipView _view;
        private readonly Ship _ship;

        public ShipPresenter(IShipView view, Ship ship)
        {
            _view = view;
            _ship = ship;
        }

        public void Fire(IDamageable damageable)
        {
            _ship.Fire(damageable);
        }
    }
}