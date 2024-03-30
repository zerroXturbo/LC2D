using UnityEngine;

public class Player : Creatures
{
    [SerializeField] private float speedRun;
    [SerializeField] private float stamina;
    
    private float _stamine;
    private bool _isRun;

    protected override float Run()
    {
        if (_isRun && _stamine > 0) { _stamine--; return speedRun; }

        if (!_isRun && _stamine <= stamina) _stamine++;

        return base.Run();
    }

    public void SetRun(bool run)
    {
        _isRun = run;
    }
}
