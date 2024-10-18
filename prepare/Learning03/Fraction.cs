using System;

class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator) {
        this._top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator) {
        this._top = numerator;
        _bottom = denominator;
    }

    public int GetTop() {
        return _top;
    }

    public void SetTop(int top) {
        _top = top;
    }
    
    public int GetBottom() {
        return _bottom;
    }

    public void SetBottom(int Bottom) {
        _bottom = Bottom;
    }

    public string GetFraction() {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue() {
        return (double) _top / _bottom;
    }
}